# RoboWriter
**Author:** *Manuel Loof*
**Date:**   *2017-10-28*


RoboWriter is an autocompleting tool for ever day writing like the autocomplete function in messengers like WhatsApp.

This is the RoboWriter server which is used by add-ins for editors like visual studio code or atom.

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

