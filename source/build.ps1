param(
    [Parameter(Mandatory=$true)][string]$GameDirectory,
    [string]$OutputDirectory = (Join-Path $PSScriptRoot 'build')
)
$ErrorActionPreference = 'Stop'
$omcManaged = Join-Path $GameDirectory 'One Million Coins_Data\Managed'
$omcCore = Join-Path $GameDirectory 'BepInEx\core'
$omcCompiler = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
$omcReferences = @(
    (Join-Path $omcManaged 'mscorlib.dll'),
    (Join-Path $omcManaged 'netstandard.dll'),
    (Join-Path $omcManaged 'System.dll'),
    (Join-Path $omcManaged 'System.Core.dll'),
    (Join-Path $omcManaged 'Assembly-CSharp.dll'),
    (Join-Path $omcManaged 'UnityEngine.dll'),
    (Join-Path $omcManaged 'UnityEngine.CoreModule.dll'),
    (Join-Path $omcManaged 'UnityEngine.TextRenderingModule.dll'),
    (Join-Path $omcManaged 'UnityEngine.JSONSerializeModule.dll'),
    (Join-Path $omcCore 'BepInEx.dll'),
    (Join-Path $omcCore '0Harmony.dll')
)
foreach ($omcFile in @($omcCompiler) + $omcReferences) {
    if (!(Test-Path -LiteralPath $omcFile)) { throw "Required file missing: $omcFile" }
}
New-Item -ItemType Directory -Path $OutputDirectory -Force | Out-Null
$omcArguments = @('/nologo', '/noconfig', '/nostdlib', '/target:library',
    ('/out:' + (Join-Path $OutputDirectory 'JapaneseLocalization.dll')))
$omcArguments += $omcReferences | ForEach-Object { '/reference:' + $_ }
$omcArguments += Join-Path $PSScriptRoot 'JapaneseLocalization.cs'
& $omcCompiler @omcArguments
if ($LASTEXITCODE -ne 0) { throw 'Compilation failed' }
Write-Output (Join-Path $OutputDirectory 'JapaneseLocalization.dll')
