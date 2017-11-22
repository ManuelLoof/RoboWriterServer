using System.Threading.Tasks;
using Xunit;

public class AutoCompleteControllerIntegrationTest : ControllerIntegrationTest
{

    [Fact]
    public async Task NextWord()
    {
        // Act
        var response = await _client.GetAsync("/api/autocomplete/das");
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.Equal("[\"Zivilleben\",\"ist\"]",
            responseString);
    }
}