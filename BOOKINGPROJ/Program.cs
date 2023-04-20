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



            Console.WriteLine(Hotels.Description(APIkey));
            //var client = new RestClient(apiCall);
            //var request = new RestRequest();
            //request.AddHeader("X-RapidAPI-Key", $"{APIkey}");
            //request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            //var response = client.Get(request);
            //var address = JObject.Parse(response.Content)["description_translations"][0]["description"].ToString();
            //Console.WriteLine(address);
            //Console.Read();

            
        }
    }
}