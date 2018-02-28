# starts the powershell consoles for git, dotnet and neo4j

# -> Git
Start-Process powershell -ArgumentList  "-NoExit cd.. | blue.ps1"

# -> dotnet
Start-Process powershell  "-NoExit cd.. | magenta.ps1"

#-> neo4j
Start-Process powershell "-NoExit cd c:\tools\neo4j-community\neo4j-community-3.2.6\bin\"
