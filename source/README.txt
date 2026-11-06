Build from source (Windows)

Requires your installed copy of One Million Coins and BepInEx 5.4.23.5 x64.
From PowerShell, run:
  ./build.ps1 -GameDirectory "C:/Program Files (x86)/Steam/steamapps/common/One Million Coins"

The output is source/build/JapaneseLocalization.dll.
The build script only creates files in its output directory. It does not
modify the game or start it. Game assemblies are referenced locally and
are not included in this package.
The editable translation file is ../BepInEx/plugins/JapaneseLocalization/ja.json.
