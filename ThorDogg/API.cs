using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ThorDogg
{
    public class ApiTheDog
    {
        public DoggModel GetCaracteristicas()
        {
            var client = new RestClient("https://api.thedogapi.com/v1/images/search");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", "5b629353-9020-4c32-acf5-4995cda6bb07");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<DoggModel> resultados = JsonConvert.DeserializeObject<List<DoggModel>>(response.Content.ToString());
                return resultados[0];
            }
            else
                return null;
        }
    }
}
