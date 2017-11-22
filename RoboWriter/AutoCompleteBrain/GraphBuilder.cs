using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoboWriter.AutoCompleteBrain
{
    
    /// <summary>
    /// Analysed the text and compute the word connections.
    /// </summary>
    public class GraphBuilder : IDisposable
    {
        #region private members

        Dictionary<string,string> _words = new Dictionary<string,string>();
        List<string> _wordConnections = new List<string>();  

        DBProvider _graphDB = new DBProvider();

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
            if(String.IsNullOrWhiteSpace(text)) 
                return;

            var sentences = GetSentences(text);

            foreach (var sentence in sentences)
            {
                AddSentence(sentence);
            }

        }
        
        public void Dispose()
        {
            _graphDB.Dispose();
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
        /// Get sentences.
        /// </summary>
        /// <param name="text">The whole text.</param>
        /// <returns>A List af sentences.</returns>
        private string[] GetSentences(string text) => Regex.Split(text,@"[.?!]");

        /// <summary>
        /// Adds the word to the graph.
        /// </summary>
        /// <param name="word"></param>
        private void AddSentence(string sentence)
        {
           AddSentence2GraphDB(GetWordElements(sentence)); 
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

        private void AddSentence2GraphDB(string[] sentence)
        {
            _graphDB.AddWordChain(sentence.ToList());
        }

        #endregion


    }    
}

