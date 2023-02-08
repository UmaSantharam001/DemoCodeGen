using System.Net.Http;


namespace Estimate.ServiceGateway.Interfaces
{
    internal interface IHttpClientConfiguration
    {
        abstract HttpClient GetConfiguration();
    }
}
