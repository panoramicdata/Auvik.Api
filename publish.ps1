$ErrorActionPreference = "Stop"

# Read the NuGet API key
$keyFile = Join-Path $PSScriptRoot "nuget-key.txt"
if (-not (Test-Path $keyFile)) {
    Write-Error "nuget-key.txt not found. Create it in the repo root with your NuGet API key."
    exit 1
}
$apiKey = (Get-Content $keyFile -Raw).Trim()

# Build in Release
dotnet build "$PSScriptRoot\Auvik.Api\Auvik.Api.csproj" -c Release
if ($LASTEXITCODE -ne 0) {
    Write-Error "Build failed."
    exit 1
}

# Find the generated .nupkg
$nupkg = Get-ChildItem "$PSScriptRoot\Auvik.Api\bin\Release\*.nupkg" | Sort-Object LastWriteTime -Descending | Select-Object -First 1
if (-not $nupkg) {
    Write-Error "No .nupkg found."
    exit 1
}

Write-Output "Publishing $($nupkg.Name)..."
dotnet nuget push $nupkg.FullName --source https://api.nuget.org/v3/index.json --api-key $apiKey --skip-duplicate
if ($LASTEXITCODE -ne 0) {
    Write-Error "Publish failed."
    exit 1
}

# Extract version from filename (Auvik.Api.x.y.z.nupkg)
$version = $nupkg.BaseName -replace '^Auvik\.Api\.', ''
Write-Output "Published Auvik.Api $version"

& "$PSScriptRoot\CheckForNugetPublish.ps1" -packageName "Auvik.Api" -expectedVersion $version
