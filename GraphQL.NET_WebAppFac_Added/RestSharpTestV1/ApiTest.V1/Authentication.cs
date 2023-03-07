using FluentAssertions;
using RestSharp;
using Xunit.Abstractions;
using System;
using System.Threading.Tasks;
using Xunit;
using GraphQLProductApp.Data;
using GraphQLProductApp.Controllers;
using Newtonsoft.Json.Linq;

namespace ApiTest.V1
{
    public class Authentication
    {
        private readonly ITestOutputHelper _output;
        private RestClientOptions _restClientOptions;

        public Authentication(ITestOutputHelper testOutputHelper)
        {
            this._output = testOutputHelper;
            _restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri("https://localhost:5001/"),
                RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
            };
        }

        [Fact]
        public async Task Login_ExampleAnonymousObjectPassedAsBody()
        {
            //Rest Client
            var client = new RestClient(_restClientOptions);
            //Rest Request
            var authRequest = new RestRequest("api/Authenticate/Login");
            authRequest.AddJsonBody(new
            {
                username = "kk",
                password = "123456"
            });
            //Perform GET operation
            var response = await client.PostAsync(authRequest);
            //Assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            //response?.Price.Should().Be(400);

        }

        [Fact]
        public async Task GetQuerryParametersTest()
        {

            //Rest Client
            var client = new RestClient(_restClientOptions);
            //Rest Request
            var authRequest = new RestRequest("api/Authenticate/Login");
            //Typed object being passed as a body in the request
            authRequest.AddJsonBody(new LoginModel
            {
                UserName = "kk",
                Password = "123456"
            });
            //Perform GET operation
            var authResponse = client.PostAsync(authRequest).Result.Content;

            //token from Json object
            var token = JObject.Parse(authResponse)["token"];
            _output.WriteLine($"token: {token}");
            //Assert
            //response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            //response?.Price.Should().Be(400);

            //Rest Request
            var productGetRequest = new RestRequest("Product/GetProductById/1");
            productGetRequest.AddHeader("Authorization", $"Bearer {token?.ToString()}");
            //Perform GET operation
            var ProductGetResponse = await client.GetAsync<Product>(productGetRequest);
            //Assert
            ProductGetResponse?.Name.Should().Be("Keyboard");
            _output.WriteLine($"First test: {ProductGetResponse?.Name}");
        }
    }
}
