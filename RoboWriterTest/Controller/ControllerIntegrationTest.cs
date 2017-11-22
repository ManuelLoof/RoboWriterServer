using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using RoboWriter;
using Microsoft.AspNetCore.TestHost;

public abstract class ControllerIntegrationTest
{
    protected readonly TestServer _server;
    protected readonly HttpClient _client;
    public ControllerIntegrationTest()
    {
        // Arrange
        _server = new TestServer(new WebHostBuilder()
            .UseStartup<Startup>());
        _client = _server.CreateClient();
    }

   
}