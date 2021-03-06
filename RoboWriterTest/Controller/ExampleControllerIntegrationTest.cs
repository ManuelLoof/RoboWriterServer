using System.Threading.Tasks;
using Xunit;

public class ExampleControllerIntegrationTest : ControllerIntegrationTest
{

    [Fact]
    public async Task ReturnHelloWorld()
    {
        // Act
        var response = await _client.GetAsync("/api/example");
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.Equal("[\"value1\",\"value2\"]",
            responseString);
    }
}