using System;
using System.Collections.Generic;
using Neo4j.Driver;

public class DB
{
    public void Test()
    {
        // using (var driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "neo4j")))
        // using (var session = driver.Session())
        // {
        //     session.Run("CREATE (a:Person {name: {name}, title: {title}})",
        //                 new Dictionary<string, object> { {"name", "Arthur"}, {"title", "King"} });

        //     var result = session.Run("MATCH (a:Person) WHERE a.name = {name} " +
        //                             "RETURN a.name AS name, a.title AS title",
        //                             new Dictionary<string, object> { {"name", "Arthur"} });

        //     foreach (var record in result)
        //     {
        //         Console.WriteLine($"{record["title"].As<string>()} {record["name"].As<string>()}");
        //     }
        // }
    }
}