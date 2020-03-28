$OpenApiDocument = ".\datetime.yaml"
$GeneratedSourceOutputDir = ".\server-generated"
$GeneratedSourcePackageName = "DateTimeMicroservice.Server.OpenApiGenerated"

function Remove-DirectoryIfExists($directory) {
    $fullPath = Resolve-Path $directory

    if ([io.directory]::Exists($fullPath)) {
        Get-Item $fullPath | Remove-Item -Force -Recurse
    }
}

#remove $GeneratedSourceOutputDir if exists
Remove-DirectoryIfExists $GeneratedSourceOutputDir

java -jar .\openapi-generator-cli.jar `
    generate `
    -i $OpenApiDocument `
    -o $GeneratedSourceOutputDir `
    -g aspnetcore `
    --package-name $GeneratedSourcePackageName