# Publish

Arguments: --output "$(Build.ArtifactStagingDirectory)"

Setting: do not publish web app

Path to project: **/*.csproj

# Posh

Write-Host "Hello World"

Write-Host "$(Foo)"

Write-Host "$(FooSecret)"

# CMD

echo "Listing files in the default working directory:"

dir $(System.DefaultWorkingDirectory) /S

# Version

$newBuildNumber = "Foo-$(Build.BuildNumber)"

Write-Host "##vso[build.updatebuildnumber]$newBuildNumber"
