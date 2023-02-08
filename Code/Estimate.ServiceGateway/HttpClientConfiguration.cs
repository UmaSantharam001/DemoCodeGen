using Microsoft.Extensions.Configuration;
using System;
using System.Configuration.Abstractions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Collections.Generic;
using Estimate.ServiceGateway.Interfaces;

namespace Estimate.ServiceGateway
{
    public class HttpClientConfiguration : IHttpClientConfiguration
    {
        private HttpClient client;
        private ConfigurationManager configuration;
        public HttpClientConfiguration()
        {
            client = new HttpClient();
            configuration = new ConfigurationManager();

        }
        public HttpClient GetConfiguration()
        {
           // var host = configuration.GetSection<string>("SecurityToken:Host");
           //var uri = configuration.GetSection("SecurityToken").GetSection("tokenPath").Value;
            var headers = new Dictionary<string, string>();
            // headers.Add("client_id", configuration.GetSection<string>("SecurityToken:client_id"));
            // headers.Add("client_secret", configuration.GetSection<string>("SecurityToken:client_secret"));
            // client.BaseAddress = new Uri();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public HttpClient ClaimSendClientConfiguration(string userName, string password)
        {
            var encrptionKey = configuration.GetSection<string>("Claim:DESEncryptionKey");
            var credentials = new NetworkCredential(userName, password);
            var handler = new HttpClientHandler { Credentials = credentials };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
            client = new HttpClient(handler);
            return client;
        }


    }
}
