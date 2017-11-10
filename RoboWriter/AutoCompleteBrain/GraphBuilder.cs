using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RoboWriter.AutoCompleteBrain
{
    
    /// <summary>
    /// Analysed the text and compute the word connections.
    /// </summary>
    public class GraphBuilder
    {
        #region private members

        Dictionary<string,string> _words = new Dictionary<string,string>();
        List<string> _wordConnections = new List<string>();  

        #endregion

        #region constructor
        
        public GraphBuilder()
        {
            LoadExistingWords();
            LoadExistingWoedConnections(); 
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
                AddWord(word);
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

        /// <summary>
        /// Adds the word to the graph.
        /// </summary>
        /// <param name="word"></param>
        private void AddWord(string word)
        {
            if(!_words.ContainsKey(word))
            {
                AddWord2GraphDB(word); 
            }
        }


        /// <summary>
        /// Loading the existing Words out of the graphdb into the cache.
        /// </summary>
        private void LoadExistingWords()
        {
            //ToDo: Load the words from graphdb.
        }

        /// <summary>
        /// Loading the existing Words connections out of the graphdb into the cache.
        /// </summary>
        private void LoadExistingWoedConnections()
        {
            //ToDo: Load the words from graphdb.
        }

        private void AddWord2GraphDB(string word)
        {
            throw new NotImplementedException();
        }


        #endregion


    }    
}

