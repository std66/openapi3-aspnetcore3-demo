$OpenApiDocument = ".\datetime.yaml"
$GeneratedSourceOutputDir = ".\server-generated"
$GeneratedSourcePackageName = "DateTimeMicroservice.Server.OpenApiGenerated"

function Remove-DirectoryIfExists($directory) {
    $fullPath = Resolve-Path $directory

    if ([io.directory]::Exists($fullPath)) {
        Get-Item $fullPath | Remove-Item -Force -Recurse
    }
}

#remove previous generated code if exists
Remove-DirectoryIfExists $GeneratedSourceOutputDir

java -jar .\openapi-generator-cli.jar `
    generate `
    -i $OpenApiDocument `
    -o $GeneratedSourceOutputDir `
    -g aspnetcore `
    -p generateBody=false,aspnetCoreVersion=3.0,isLibrary=true,buildTarget=library,operationModifier=abstract,useDefaultRouting=false `
    --package-name $GeneratedSourcePackageName