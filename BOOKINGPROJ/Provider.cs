using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKINGPROJ
{
    internal class Provider
    {
        public static string Description(string apiKey)
        {
            //wtf?
            var client = new RestClient("https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id=1377073&locale=en-gb");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var description = JObject.Parse(response.Content)["description_translations"][0]["description"].ToString();
            return description;


        }
    }
}
