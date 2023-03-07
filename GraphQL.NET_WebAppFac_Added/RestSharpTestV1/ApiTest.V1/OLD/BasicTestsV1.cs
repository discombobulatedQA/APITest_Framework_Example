using FluentAssertions;
using RestSharp;
using Xunit.Abstractions;
using System;
using System.Threading.Tasks;
using Xunit;
using GraphQLProductApp.Data;

namespace ApiTest.V1.OLD
{
    public class BasicTestsV1
    {
        //First set of tests written and commented out to look at later

        //private readonly ITestOutputHelper _output;

        //public BasicTestsV1(ITestOutputHelper testOutputHelper)
        //{
        //    this._output = testOutputHelper;
        //}

        //[Fact]
        //public async Task GetOperationTest()
        //{
        //    var restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };

        //    //Rest Client
        //    var client = new RestClient(restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product/GetProductById/1");
        //    //Perform GET operation
        //    var response = await client.GetAsync<Product>(request);
        //    //Assert
        //    response?.Name.Should().Be("Keyboard");


        //    _output.WriteLine($"First test: {response?.Name}");
        //}

        //[Fact]
        //public async Task GetSegmentTest()
        //{
        //    var restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };

        //    //Rest Client
        //    var client = new RestClient(restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product/GetProductById/{id}");
        //    request.AddUrlSegment("id", 2);
        //    //Perform GET operation
        //    var response = await client.GetAsync<Product>(request);
        //    //Assert
        //    response?.Price.Should().Be(400);


        //}

        //[Fact]
        //public async Task GetQuerryParametersTest()
        //{
        //    var restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };

        //    //Rest Client
        //    var client = new RestClient(restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product​/GetProductByIdAndName");
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
        //    var restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };

        //    //Rest Client
        //    var client = new RestClient(restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("/Product/Create");
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
        //    var restClientOptions = new RestClientOptions
        //    {
        //        BaseUrl = new Uri("https://localhost:5001/"),
        //        RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        //    };

        //    //Rest Client
        //    var client = new RestClient(restClientOptions);
        //    //Rest Request
        //    var request = new RestRequest("Product", Method.Post);
        //    request.AddFile("myFile", @"C:\01 - stevens files\Steven\downloads\CSC00386.jpg", "multipart/form-data");
        //    //Perform Execute operation
        //    var response = await client.ExecuteAsync(request);
        //    //Assert
        //    response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);


        //    //_output.WriteLine($"First test: {response?.Name}");
        //}
    }
}