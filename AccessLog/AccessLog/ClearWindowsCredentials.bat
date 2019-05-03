@echo off
cmdkey /list | ForEach-Object{if($_ -like "*Target:*" -and $_ -like "*microsoft*, *outlook*, *onedrive*"){cmdkey /del:($_ -replace " ","" -replace "Target:","")}}
pause