using Newtonsoft.Json.Linq;
using RestSharp;
using System.Security.Cryptography.X509Certificates;

namespace BOOKINGPROJ
{
    public class Program
    {
        static void Main(string[] args)
        {

            //string key = File.ReadAllText("appsettings.json");
            //string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();
            //string apiCall = $"https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id=1377073&locale=en-gb";

            Console.WriteLine("What city would you like to search?");
            var city = Console.ReadLine().ToLower();

            Hotels.City(KeyHolder.GetKey(), city);

            //var client = new RestClient($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-us");
            //var request = new RestRequest();
            //request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            //request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            //var response = client.Execute(request);
            //var destID = JArray.Parse(response.Content)[0]["dest_id"].ToString();
            //Console.WriteLine(destID);



            Hotels.HotelID(KeyHolder.GetKey(), Hotels.HotelID(KeyHolder.GetKey(), city));

            //Console.WriteLine(Hotels.Search(apiKey, Hotels.City(apiKey)));

            //Console.WriteLine(Hotels.HotelID(apiKey, destID));

            //Console.WriteLine(Hotels.Description(apiKey));

            Console.WriteLine(Hotels.Description(KeyHolder.GetKey(), Hotels.HotelID(KeyHolder.GetKey(), city)));
            Console.WriteLine(Hotels.Value(KeyHolder.GetKey(), Hotels.City(KeyHolder.GetKey(), city)));

            Console.WriteLine(Hotels.Name(KeyHolder.GetKey(), Hotels.City(KeyHolder.GetKey(), city)));

            Console.WriteLine(Hotels.Score(KeyHolder.GetKey(), Hotels.City(KeyHolder.GetKey(), city)));



            //var client = new RestClient("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-us");
            //var request = new RestRequest();
            //request.AddHeader("X-RapidAPI-Key", "7b5c999cdcmsh26c0a24ac75c4d0p17ad3bjsn03f1cbc956be");
            //request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");

            //var response = client.Execute(request);



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