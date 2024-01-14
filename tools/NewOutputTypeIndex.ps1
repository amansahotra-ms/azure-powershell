param(
    [Parameter(Mandatory = $false)]
    [string] $BuildConfig = "Debug",
    [Parameter(Mandatory = $false)]
    [string] $OutputFile = "$PSScriptRoot/outputtypes.json"
)
$nestedModuleNames = New-Object System.Collections.Generic.HashSet[string]

$psd1Files = Get-Item $PSScriptRoot\..\artifacts\$BuildConfig\Az.*\Az.*.psd1
$modules = New-Object System.Collections.Generic.HashSet[string]
$psd1Files | ForEach {
    Import-LocalizedData -BindingVariable "psd1File" -BaseDirectory $_.DirectoryName -FileName $_.Name
    $moduleName = $_.BaseName
    foreach ($nestedModule in $psd1File.NestedModules)
    {
        if('.dll' -eq [System.IO.Path]::GetExtension($nestedModule)) 
        {
            $modules.add($moduleName) | Out-Null
            $nestedModuleNames.Add($nestedModuleName) | Out-Null
            continue;
        }
    }
}
$toolsPath = "$PSScriptRoot/../tools/Tools.Common/SerializedCmdlets"
$jsons = Get-ChildItem -Path $toolsPath -Recurse | Where-Object { $modules -contains $_.BaseName}
$outputTypes = New-Object System.Collections.Generic.HashSet[string]
$jsons | ForEach {
    $jsonContent = Get-Content -Path $_.FullName
    $jsonObject = $jsonContent | ConvertFrom-Json
    $jsonObject.Cmdlets | ForEach {
        $_.OutputTypes | ForEach {
            if ([string]::IsNullOrWhiteSpace($_.Type.Name) -eq $false -and 
                $_.Type.Name -notmatch '\d{6,}' -and
                -not ($nestedModuleNames -contains $_.Type.AssemblyQualifiedName)) {
                $outputTypes.add($_.Type.Name)  | Out-Null
            }
        }
        $_.Parameters | ForEach {
            if ([string]::IsNullOrWhiteSpace($_.Type.Name) -eq $false -and 
                $_.Type.Name -notmatch '\d{6,}' -and 
                -not ($nestedModuleNames -contains $_.Type.AssemblyQualifiedName)) {
                if ($property.PropertyType.FullName -like "*System.Nullable*``[``[*") {
                    $outputTypes.Add(($_.Type.GenericTypeArguments -replace "[][]", "")) | Out-Null
                }
                elseif ($_.Type.Name -notlike "*``[*" -or $_.Type.Name -like "*``[``]*") {
                    $outputTypes.Add(($_.Type.Name -replace "[][]", "")) | Out-Null
                }
            }
        }
    }
}

$json = ConvertTo-Json $outputTypes
$json | Out-File "$OutputFile"