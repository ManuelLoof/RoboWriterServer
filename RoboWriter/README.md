# RoboWriter
Author: Manuel Loof
Date:   2017-10-28


RoboWriter is an autocompleting tool for ever day writing like the autocomplete function in messengers like WhatsApp.

This is the RoboWriter server which is used by add-ins for editors like visual studio code or atom.

## Architecture

    +---Controllers
    |   +---SeassonIDController
    |   +---TextController
    |   +---AutoCompleteController
    +---AutoCompleteBrain
    |   +---TaskScheduler
    |   +---GraphBuilder
    |   +---Suggestion
