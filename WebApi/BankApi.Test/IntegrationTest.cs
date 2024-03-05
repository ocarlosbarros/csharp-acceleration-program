using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BankApi.Test;

public class IntegrationTest: IClassFixture<WebApplicationFactory<Program>>
{
    public HttpClient _clientTest;
    
    public IntegrationTest(WebApplicationFactory<Program> factory)
    {
        _clientTest = factory.CreateClient();
    }

    [Theory(DisplayName = "Testing the route /GET Clients")]
    [InlineData("/clients")]
    public async Task TestGetClients(string url)
    {
        var response = await _clientTest.GetAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.OK, response?.StatusCode);
    }
}