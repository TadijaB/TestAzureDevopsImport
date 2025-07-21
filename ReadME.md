# Publish

```
Arguments: --output "$(Build.ArtifactStagingDirectory)"
Setting: do not publish web app
Path to project: **/*.csproj
```
# Version
```posh
$newBuildNumber = "$(MyVersion)-$(Build.BuildNumber)"
Write-Host "##vso[build.updatebuildnumber]$newBuildNumber"
```
# Posh
``` posh
Write-Host "Hello World"
Write-Host "$(Foo)"
Write-Host "$(FooSecret)"
```
# CMD
```cmd
echo "Listing files in the default working directory:"
dir $(System.DefaultWorkingDirectory) /S
```

