using System.Linq;
using Xunit;

public class DBProviderTest
{
    [Fact]
    public void AddWordChainTest()
    {
        using(var db = new DBProvider())
        {
            db.AddWordChain("Ich glaub ich steh im Wald.".Split(" ").ToList()); 
        }
    }
    
    [Fact]
    public void GetNextWordTest()
    {
        using(var db = new DBProvider())
        {
            var nextWords = db.GetNextWords("ich"); 

            Assert.True(nextWords.Count == 6); 
            Assert.True(nextWords[0] == "nicht"); 
            Assert.True(nextWords[1] == "einen"); 
            Assert.True(nextWords[2] == "bin"); 
            Assert.True(nextWords[3] == "decke"); 
            Assert.True(nextWords[4] == "zurückkam"); 
            Assert.True(nextWords[5] == "steh"); 

        }
    }    
}