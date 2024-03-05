using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BankApi.Test;

public class IntegrationTest: IClassFixture<WebApplicationFactory<Program>>
{
    public HttpClient _customerTest;
    
    public IntegrationTest(WebApplicationFactory<Program> factory)
    {
        _customerTest = factory.CreateClient();
    }

    [Theory(DisplayName = "Testing the route /GET Customers")]
    [InlineData("/customers")]
    public async Task TestGetCustomers(string url)
    {
        var response = await _customerTest.GetAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.OK, response?.StatusCode);
    }
}