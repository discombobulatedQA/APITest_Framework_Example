using FluentAssertions;
using RestSharp;
using Xunit.Abstractions;
using System;
using System.Threading.Tasks;
using Xunit;
using GraphQLProductApp.Data;
using GraphQLProductApp.Controllers;
using Newtonsoft.Json.Linq;
using ApiTest.V1.Base;
using System.Net;

namespace ApiTest.V1;
public class BasicTests
{
    private readonly IRestFactory _restFactory;
    private readonly string? _token;

    public BasicTests(IRestFactory restFactory)
    {
        _restFactory = restFactory;
        _token = GetToken();
    }


    [Fact]
    public async Task GetOperationTest()
    {
        var response = await _restFactory.Create()
            .WithRequest("Product/GetProductById/1")
            .WithHeader("Authorization", $"Bearer {_token}")
            .WithGet<Product>();
        //Assert
        response?.Name.Should().Be("Keyboard");
    }

    [Fact]
    public async Task GetWithQuerySegmentTest()
    {
        var response = await _restFactory.Create()
            .WithRequest("Product/GetProductById/{id}")
            .WithUrlSegment("id", "2")
            .WithHeader("Authorization", $"Bearer {_token}")
            .WithGet<Product>();
        //Assert
        response?.Price.Should().Be(400);
    }

    [Fact]
    public async Task GetWithQueryParameterTest()
    {
        var response = await _restFactory.Create()
            .WithRequest("Product/GetProductByIdAndName")
            .WithQueryParameter("id", "2")
            .WithQueryParameter("name", "Monitor")
            .WithHeader("Authorization", $"Bearer {_token}")
            .WithGet<Product>();
        //Assert
        response?.Price.Should().Be(400);
    }


    [Fact]
    public async Task PostProductTest()
    {
        var response = await _restFactory.Create()
            .WithRequest("Product/Create")
            .WithBody(new Product
            {
                Name = "Cabinet",
                Description = "Gaming Cabinet",
                Price = 300,
                ProductType = ProductType.PERIPHARALS
            })
            .WithHeader("Authorization", $"Bearer {_token}")
            .WithPost<Product>();
        //Assert
        response?.Price.Should().Be(300);
    }

    //Students to work
    //[Fact]
    //public async Task FileUploadTest()
    //{
    //    //Rest Request
    //    var request = new RestRequest("Product", Method.Post);
    //    request.AddHeader("Authorization", GetToken());
    //    request.AddFile("myFile", @"C:\01 - stevens files\Steven\downloads\CSC00386.jpg", "multipart/form-data");
    //    //Perform Execute operation
    //    var response = await _client.ExecuteAsync(request);
    //    //Assert
    //    response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);


    //    //_output.WriteLine($"First test: {response?.Name}");
    //}

    [Fact]
    public async Task FileUploadTest()
    {
        var response = await _restFactory
            .Create()
            .WithRequest("Product")
            .WithHeader("Authorization", $"Bearer {_token}")
            .WithFile("myFile", @"C:\01 - stevens files\Steven\downloads\CSC00386.jpg", "multipart/form-data")
            .WithPost();
        response.StatusCode.Should().Be(HttpStatusCode.Created);
    }

    private string GetToken()
    {
        var authResponse = _restFactory
            .Create()
            .WithRequest("api/Authenticate/Login")
            .WithBody(new LoginModel
            {
                UserName = "KK",
                Password = "123456"
            })
            .WithPost().Result.Content;

        //Token from JSON object
        return JObject.Parse(authResponse)["token"].ToString();
    }
}