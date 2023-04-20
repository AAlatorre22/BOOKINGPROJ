using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace BOOKINGPROJ
{
    public class Cities
    {

        public static string City(string apiKey)
        {
            Console.WriteLine("What city would you like to search?");
            var city = Console.ReadLine();
            var client = new RestClient($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-us");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var hotels = JObject.Parse(response.Content)[0]["name"].ToString();
            return hotels;


        }



    }
}
