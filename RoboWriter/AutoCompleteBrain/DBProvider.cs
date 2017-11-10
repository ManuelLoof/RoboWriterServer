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
        using (var session = _driver.Session())
        {

            var mergeCypher = GenerateMergeCypher(words); 
            session.Run(mergeCypher);
        }
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
        var cypher = new StringBuilder();
        int wordCount = 0;

        foreach (var word in words)
        {
            cypher.AppendLine($"w{wordCount++}:MERGE (word {{ value: {{{word}}})");
        }

        return cypher.ToString(); 
    }

    
    #endregion


    #region IDisposable Support
    public void Dispose()
    {
        _driver.Dispose();
    }


    #endregion
}