using Xunit;
using RoboWriter.AutoCompleteBrain; 

class GraphBuilderTest
{
    [Fact]
    public void SetText()
    {
        var builder = new GraphBuilder();
        builder.SetText("Das ist mein aller erster Test.");
    }
}