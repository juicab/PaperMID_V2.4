using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace PaperMID.WebService
{
    public class ServicioAPI
    {
        public HttpClient Cliente;
        private MediaTypeWithQualityHeaderValue contentType;
        private string Url_Local = "http://localhost:50949";
        private string Url_Web = "http://webservicepapermidapi20180226124721.azurewebsites.net/";
        public ServicioAPI()
        {
            contentType = new MediaTypeWithQualityHeaderValue("application/json");
            Cliente = new HttpClient()
            {
                BaseAddress = new Uri(Url_Web)
            };
            Cliente.DefaultRequestHeaders.Accept.Add(contentType);
        }
    }
}