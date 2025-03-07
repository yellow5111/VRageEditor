@echo off
title VRage MB Launcher

echo ====================================================
echo IMPORTANT: This launcher requires the VS2012 x86 redistributables.
echo Please download and install them from:
echo   https://www.microsoft.com/en-au/download/details.aspx?id=30679
echo ====================================================
pause

cd Plugins\ModelBuilder\
start "" "..\..\Bin\VRageEditor.exe" "profile:ModelBuilder"
