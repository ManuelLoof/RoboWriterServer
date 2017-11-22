using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

public class TextControllerIntegrationTest : ControllerIntegrationTest
{

    [Fact]
    //[Fact(Skip="inital test")]
    public async Task SetText()
    {
        // Act
        var response = await _client.PostAsync("/api/text", new StringContent("'Wozu ist das? Das ist blaues Licht. Und was macht es? Es leuchtet blau.'", Encoding.UTF8, "application/json"));
        response.EnsureSuccessStatusCode();

        Assert.True(response.IsSuccessStatusCode);
    }
}