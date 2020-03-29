$OpenApiDocument = ".\datetime.yaml"
$GeneratedSourceOutputDir = ".\server-generated"
$GeneratedSourcePackageName = "DateTimeMicroservice.Server.OpenApiGenerated"

function Remove-DirectoryIfExists($directory) {
    $fullPath = ""

    try {
        $fullPath = Resolve-Path $directory -ErrorAction Stop
    }
    catch [System.Management.Automation.ItemNotFoundException] {
        return
    }
    
    if ([io.directory]::Exists($fullPath)) {
        Get-Item $fullPath | Remove-Item -Force -Recurse
    }
}

#remove previous generated code if exists
Remove-DirectoryIfExists $GeneratedSourceOutputDir

#run code generator
java -jar .\openapi-generator-cli.jar `
    generate `
    -i $OpenApiDocument `
    -o $GeneratedSourceOutputDir `
    -g aspnetcore `
    -p generateBody=false,aspnetCoreVersion=3.0,isLibrary=true,buildTarget=library,operationModifier=abstract,useDefaultRouting=false `
    --package-name $GeneratedSourcePackageName

#copy necessary files to solution
$itemsToCopy = @(
    'Attributes',
    'Authentication',
    'Controllers',
    'Converters',
    'Models'
)

$target = "..\$GeneratedSourcePackageName\"
foreach ($itemToCopy in $itemsToCopy) {
    $source = ".\$GeneratedSourceOutputDir\src\$GeneratedSourcePackageName\$itemToCopy"
    Remove-DirectoryIfExists $($target + $itemToCopy)
    Copy-Item -Path $source -Destination $target -Recurse
}

#remove generated code
Remove-DirectoryIfExists $GeneratedSourceOutputDir