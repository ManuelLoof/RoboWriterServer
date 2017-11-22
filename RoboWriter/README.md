# RoboWriter
**Author:** *Manuel Loof*
**Date:**   *2017-10-28*


RoboWriter is an autocompleting tool for ever day writing like the autocomplete function in messengers like WhatsApp.

This is the RoboWriter server which is used by add-ins for editors like visual studio code or atom.

- [RoboWriter](#robowriter)
    - [Architecture](#architecture)
    - [Toolchain](#toolchain)
        - [.net core](#net-core)
        - [Neo4J](#neo4j)
        - [Packages](#packages)

## Architecture


    +---Controllers
    |   +---SeassonIDController.cs     // Starts the seassion.
    |   +---TextController.cs          // Transmitted the actual text.
    |   +---AutoCompleteController.cs  // Get the next suggestion.
    +---AutoCompleteBrain
    |   +---TaskScheduler.cs           // Taskrunner that works step by step the ToDos and comunicates with the graph db.
    |       +---Task.cs                // A task to work off.
    |   +---GraphBuilder.cs            // Analysed the text and compute the word connections.
    |   +---Suggestion.cs              // Gets the next expected for the sentence.
    |   +---DBProvider.cs              // The connection class to the graph db.
    +---Tooling                        // Folder for tooling stuff.
    |   +---startConsoles.bat          // starts the powershell consoles for git, dotnet and neo4j
    +---Program.cs                     // Program start
    +---Startup.cs                     // The mvc Startup class.
    +---README.md                      // This readme file.

## Toolchain

- .net core
- neo4j
- nuget

### .net core

```shell 
> dotnet build      // Builds the assembly
```

### Neo4J

- Neo4J gets installed with choclatey with the command `choco install neo4j-community`.
- The software is located `c:\tools\neo4j-community\neo4j-community-3.2.6\bin\`
- The server gets started by `c:\tools\neo4j-community\neo4j-community-3.2.6\bin\neo4j.bat`

```shell 
> cd c:\tools\neo4j-community\neo4j-community-3.2.6\bin\
> neo4j start       // Starts service.
> neo4j console     // Starts service hosted in a console.
```

### Packages

Packages will be add over

```shell 
dotnet add package 
```

Example:
```shell
dotnet add package Microsoft.AspNetCore.TestHost --version 2.0.1
``` 



