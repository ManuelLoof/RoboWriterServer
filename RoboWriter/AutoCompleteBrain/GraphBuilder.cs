using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RoboWriter.AutoCompleteBrain
{
    
    /// <summary>
    /// Analysed the text and compute the word connections.
    /// </summary>
    internal class GraphBuilder
    {
        #region private members

        #endregion

        #region constructor
        
        public GraphBuilder()
        {
        }

        #endregion

        #region public members

        /// <summary>
        /// Analysed the text and compute the word connections.
        /// </summary>
        /// <param name="text">The text to analyse.</param>
        public void SetText(string text)
        {
            var wordElements = GetWordElements(text);

            foreach (var word in wordElements)
            {
                
            }

        }


        #endregion

        #region private members

        /// <summary>
        /// Extract the single words from the text.
        /// </summary>
        /// <param name="text">The text to analyse.</param>
        /// <returns>An array of the words in the text orderd by the position in the text.</returns>
        private string[] GetWordElements(string text) => Regex.Split(text,@"\W"); // Splitt the text at any character that is not a word character.

        #endregion


    }    
}

