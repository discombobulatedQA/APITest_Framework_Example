using FluentAssertions;
using RestSharp;
using Xunit.Abstractions;
using System;
using System.Threading.Tasks;
using Xunit;
using GraphQLProductApp.Data;
using GraphQLProductApp.Controllers;
using Newtonsoft.Json.Linq;

namespace ApiTest.V1.OLD
{
    public class BasicTestsV2
    {
        //Second set of tests written and commented out to look at later

        //private readonly ITestOutputHelper _output;
        //private RestClientOptions _restClientOptions;

        //public BasicTestsV2(ITestOutputHelper testOutputHelper)
        //{
        //    this._output = testOutputHelper;
        //    _restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };
        //}

        //[Fact]
        //public async Task GetOperationTest()
        //{


        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product/GetProductById/1");
        //    request.AddHeader("Authorization", GetToken());
        //    //Perform GET operation
        //    var response = await client.GetAsync<Product>(request);
        //    //Assert
        //    response?.Name.Should().Be("Keyboard");


        //    _output.WriteLine($"First test: {response?.Name}");
        //}

        //[Fact]
        //public async Task GetSegmentTest()
        //{
        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product/GetProductById/{id}");
        //    request.AddHeader("Authorization", GetToken());
        //    request.AddUrlSegment("id", 2);
        //    //Perform GET operation
        //    var response = await client.GetAsync<Product>(request);
        //    //Assert
        //    response?.Price.Should().Be(400);


        //}

        //[Fact]
        //public async Task GetQuerryParametersTest()
        //{
        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product​/GetProductByIdAndName");
        //    request.AddHeader("Authorization", GetToken());
        //    request.AddQueryParameter("id", 2);
        //    request.AddQueryParameter("name", "monitor");
        //    //Perform GET operation
        //    var response = await client.GetAsync<Product>(request);
        //    //Assert
        //    response?.Price.Should().Be(400);

        //}

        //[Fact]
        //public async Task PostProductTest()
        //{
        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("/Product/Create");
        //    request.AddHeader("Authorization", GetToken());
        //    request.AddJsonBody(new Product
        //    {
        //        Name = "Cabinet",
        //        Description = "Gaming ",
        //        Price = 500,
        //        ProductType = ProductType.PERIPHARALS
        //    });
        //    //Perform Post operation
        //    var response = await client.PostAsync<Product>(request);
        //    //Assert
        //    response?.Price.Should().Be(500);

        //}

        //[Fact]
        //public async Task FileUploadTest()
        //{
        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product", Method.Post);
        //    request.AddHeader("Authorization", GetToken());
        //    request.AddFile("myFile", @"C:\01 - stevens files\Steven\downloads\CSC00386.jpg", "multipart/form-data");
        //    //Perform Execute operation
        //    var response = await client.ExecuteAsync(request);
        //    //Assert
        //    response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);


        //    //_output.WriteLine($"First test: {response?.Name}");
        //}


        //private string GetToken()
        //{
        //    //Rest Client
        //    var client = new RestClient(_restClientOptions);
        //    //Rest Request
        //    var authRequest = new RestRequest("api/Authenticate/Login");
        //    //Typed object being passed as a body in the request
        //    authRequest.AddJsonBody(new LoginModel
        //    {
        //        UserName = "kk",
        //        Password = "123456"
        //    });
        //    //Perform GET operation
        //    var authResponse = client.PostAsync(authRequest).Result.Content;

        //    //token from Json object
        //    var token = JObject.Parse(authResponse)["token"].ToString();
        //    return $"Bearer {token}";
        //}
    }
}