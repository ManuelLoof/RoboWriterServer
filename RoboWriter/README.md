# RoboWriter
**Author:** *Manuel Loof*
**Date:**   *2017-10-28*


RoboWriter is an autocompleting tool for ever day writing like the autocomplete function in messengers like WhatsApp.

This is the RoboWriter server which is used by add-ins for editors like visual studio code or atom.

- [RoboWriter](#robowriter)
    - [Architecture](#architecture)
    - [Tools](#tools)
        - [Neo4J](#neo4j)

## Architecture


    +---Controllers
    |   +---SeassonIDController     // Starts the seassion.
    |   +---TextController          // Transmitted the actual text.
    |   +---AutoCompleteController  // Get the next suggestion.
    +---AutoCompleteBrain
    |   +---TaskScheduler           // Taskrunner that works step by step the ToDos and comunicates with the graph db.
    |       +---Task                // A task to work off.
    |   +---GraphBuilder            // Analysed the text and compute the word connections.
    |   +---Suggestion              // Gets the next expected for the sentence.

## Tools 
### Neo4J

- Neo4J gets installed with choclatey with the command `choco install neo4j-community`.
- The software is located `c:\tools\neo4j-community\neo4j-community-3.2.6\bin\`
- The server gets started by `c:\tools\neo4j-community\neo4j-community-3.2.6\bin\neo4j.bat`

```shell 
> neo4j start       // Starts service.
> neo4j console     // Starts service hosted in a console.

```
