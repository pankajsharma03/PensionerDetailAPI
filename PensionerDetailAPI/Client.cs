using System;
using System.Net.Http;

namespace PensionerDetailAPI
{
    public class Client
    {
        public HttpClient Authapi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://52.224.74.57/");
            //client.BaseAddress = new Uri("http://localhost:35485/");

            return client;
        }
    }
}
