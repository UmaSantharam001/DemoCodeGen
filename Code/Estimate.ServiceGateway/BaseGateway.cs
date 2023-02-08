using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace Estimate.ServiceGateway
{
    public class BaseGateway
    {
        private readonly IMapper _mapper;

        public BaseGateway(IMapper mapper)
        {
            _mapper = mapper;
            
        }

        public T GetData<T, U>(string requestUri)
        {
            return Get<T, U>(requestUri);
        }
        private string  Get(string requestUri)
        {

            string responseData = null;

            using (var client = new HttpClientConfiguration().GetConfiguration())
            {

                var response = client.GetAsync(requestUri).Result;

                if (response.IsSuccessStatusCode)
                    responseData = response.Content.ReadAsStringAsync().Result;
            }

            return responseData;
        }
        private T Get<T, U>(string requestUri)
        {

            string responseData = null;

            using (var client = new HttpClientConfiguration().GetConfiguration())
            {

                var response = client.GetAsync(requestUri).Result;

                if (response.IsSuccessStatusCode)
                    responseData = response.Content.ReadAsStringAsync().Result;
            }

            return _mapper.Map<T>(JsonConvert.DeserializeObject<U>(responseData));
        }
        private T AuthorizeUser<T, U>(string requestUri, string userName, string password)
        {

            string responseData = null;

            using (var client = new HttpClientConfiguration().ClaimSendClientConfiguration(userName, password))
            {

                var response = client.GetAsync(requestUri).Result;

                if (response.IsSuccessStatusCode)
                    responseData = response.Content.ReadAsStringAsync().Result;
            }

            return _mapper.Map<T>(JsonConvert.DeserializeObject<U>(responseData)); ;
        }

        public void PutData<T>(string requestUri, T value)
        {
            using (var client = new HttpClientConfiguration().GetConfiguration())
            {
                var response = client.PutAsJsonAsync(requestUri, _mapper.Map<T>(value)).Result;

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception("Unable to process your request this time.");

            }
        }

        public void PostData<T>(string requestUri, T value)
        {
            using (var client = new HttpClientConfiguration().GetConfiguration())
            {
                var response = client.PostAsJsonAsync(requestUri, _mapper.Map<T>(value)).Result;

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception("Unable to process your request this time.");

            }
        }

        public void DeleteData(string requestUri)
        {
            using (var client = new HttpClientConfiguration().GetConfiguration())
            {
                var response = client.DeleteAsync(requestUri).Result;

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception("Unable to process your request this time.");
            }
        }



    }
}
