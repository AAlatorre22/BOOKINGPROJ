using Newtonsoft.Json.Linq;
using RestSharp;

namespace BOOKINGPROJ
{
    public class Program
    {
        static void Main(string[] args)
        {

            string key = File.ReadAllText("appsettings.json");
            string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();
            string apiCall = $"https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id=1377073&locale=en-gb";

            //Console.WriteLine(Hotels.Description(apiKey));
            Console.WriteLine(Cities.City(apiKey));

            //unsure
            // Console.WriteLine(Provider.Description(Hotels.Description, KeyHolder.GetKey));





            var client = new RestClient("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-us");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "7b5c999cdcmsh26c0a24ac75c4d0p17ad3bjsn03f1cbc956be");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Execute(request);



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