using Xunit;

public class DBTest
{
    [Fact]
    public void TestConnection()
    {
        var db = new DB();
        db.Test(); 
    }    
}