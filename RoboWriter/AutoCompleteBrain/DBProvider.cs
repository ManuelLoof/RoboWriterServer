using System;
using System.Linq;
using System.Collections.Generic;
using Neo4j.Driver;
using Neo4j.Driver.V1;
using System.Text;

public class DBProvider : IDisposable
{
    #region class members

    IDriver _driver;
        
    #endregion

    #region constructor
        
    /// <summary>
    /// Constructor
    /// </summary>
    public DBProvider()
    {
         _driver = Neo4j.Driver.V1.GraphDatabase.Driver("bolt://localhost:7687", Neo4j.Driver.V1.AuthTokens.Basic("neo4j", "neo"));
    }


    /// <summary>
    /// Destructor
    /// </summary>
    ~DBProvider()
    {
        Dispose(); 
    }


    #endregion

    #region public methods
    

    /// <summary>
    /// Adds the words of a sentence constraint in the database.
    /// </summary>
    public void AddWordChain(List<string> words)
    {
        var mergeCypher = GenerateMergeCypher(words);
        DoCypher(mergeCypher);
    }

   

    /// <summary>
    /// Gets the next word.
    /// </summary>
    /// <param name="prev"></param>
    public List<string> GetNextWords(string prev)
    {
        var nextWordCypher = GenerateNextWordCypher(prev);
        return DoCypherGetNodeValue(nextWordCypher);
    }



    #endregion


    #region private methods

    /// <summary>
    /// Generates a merge query in cypher.
    /// </summary>
    /// <param name="words">The words witch are constraint together.</param>
    /// <returns>A cypher query.</returns>    
    private string GenerateMergeCypher(List<string> words)
    {

        // MERGE (w1:word { value: 'Ich'}) 
        // MERGE (w2:word { value: 'glaub'})
        // MERGE (w1)-[r:relation]->(w2)


        var cypher = new StringBuilder();
        int wordCount = 0;

        foreach (var word in words)
        {
            // MERGE (w1:word { value: 'Ich'}) 
            cypher.AppendLine($"MERGE (w{wordCount++}:word {{ value: '{word}'}})");
        }

        for (int i = 0; i < wordCount - 1; i++)
        {
            // MERGE (w1)-[r:relation]->(w2)
            cypher.AppendLine($"MERGE (w{i})-[r{i++}:relation]->(w{i--})");
        }

        return cypher.ToString(); 
    }


    private string GenerateNextWordCypher(string prev)
    {
        return $"MATCH (w1:word {{ value: '{prev}' }})-->(w2:word) RETURN w2.value";
    }

    /// <summary>
    /// Executes the cypher query.
    /// </summary>
    private void DoCypher(string cypher)
    {
        using (var session = _driver.Session())
        {        
            session.Run(cypher);
        }
    }


    /// <summary>
    /// Executes the cypher query.
    /// </summary>
    private List<string> DoCypherGetNodeValue(string cypher)
    {
        using (var session = _driver.Session())
        {        
            var result = session.Run(cypher);
            
            var output = new List<string>();
            foreach (var record in result)
            {
                output.Add(record["w2.value"].As<string>());
            }

            return output; 

        }
    }
    
    #endregion


    #region IDisposable Support
    public void Dispose()
    {
        _driver.Dispose();
    }


    #endregion
}