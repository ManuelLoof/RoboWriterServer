using System.Linq;
using Xunit;

public class DBProviderTest
{
    [Fact]
    public void TestConnection()
    {
        var db = new DBProvider();
        db.AddWordChain("Ich glaub ich steh im Wald.".Split(" ").ToList()); 
    }    
}