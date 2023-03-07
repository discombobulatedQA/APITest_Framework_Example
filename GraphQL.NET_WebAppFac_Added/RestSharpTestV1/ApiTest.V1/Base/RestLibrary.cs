using GraphQLProductApp;
using Microsoft.AspNetCore.Mvc.Testing;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ApiTest.V1.Base;

public interface IRestLibrary
{
    RestClient RestClient { get; }
}

public class RestLibrary : IRestLibrary
{
    //added webapplicationfactory here
    public RestLibrary(WebApplicationFactory<GraphQLProductApp.Startup> webApplicationFactory)
    {
        var restClientOptions = new RestClientOptions
        {
            BaseUrl = new Uri("https://localhost:5001/"),
            RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        };

        //and here
        //spaw our SUT
        var client  = webApplicationFactory.CreateDefaultClient();

        //Rest Client
        RestClient = new RestClient(client, restClientOptions);
    }

    public RestClient RestClient { get; }
}