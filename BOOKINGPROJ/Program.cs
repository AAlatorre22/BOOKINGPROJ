using Newtonsoft.Json.Linq;
using RestSharp;

namespace BOOKINGPROJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            

            string apiCall = $"https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id=1377073&locale=en-gb";

            var client = new RestClient(apiCall);
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{APIkey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            Console.WriteLine(response.Content.ToString());
            Console.Read();

        }
    }
}