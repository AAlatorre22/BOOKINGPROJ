using MySqlX.XDevAPI;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKINGPROJ
{
    internal class Hotels
    {

        public static string HotelID(string apiKey, string destID)
        {

            var client = new RestClient($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=price&adults_number=2&checkin_date=2023-09-27&filter_by_currency=USD&dest_id={destID}&locale=en-gb&checkout_date=2023-09-28&units=imperial&room_number=1&dest_type=city&children_number=2&page_number=0");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var hotelID = JObject.Parse(response.Content)["results"][0]["id"].ToString();
            return hotelID;
        }

        public static string Description(string apiKey, string hotelID)
        {
            var client = new RestClient($"https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id={hotelID}&locale=en-gb");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var description = JObject.Parse(response.Content)["description_translations"][0]["description"].ToString();
            return description;


        }




        public static string City(string apiKey, string city)
        {
            //Console.WriteLine("What city would you like to search?");
            //var city = Console.ReadLine().ToLower();
            var client = new RestClient($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-us");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Execute(request);
            var destID = JArray.Parse(response.Content)[0]["dest_id"].ToString();
            return destID;


            }



            public static string Search(string apiKey, string destID)
        {

            var client = new RestClient($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=price&adults_number=2&checkin_date=2023-09-27&filter_by_currency=USD&dest_id={destID}&locale=en-gb&checkout_date=2023-09-28&units=imperial&room_number=1&dest_type=city&children_number=2&page_number=0");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var search = JObject.Parse(response.Content).ToString();
            return search;
        }

        public static string Value(string apiKey, string destID)
        {

            var client = new RestClient($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=price&adults_number=2&checkin_date=2023-09-27&filter_by_currency=USD&dest_id={destID}&locale=en-gb&checkout_date=2023-09-28&units=imperial&room_number=1&dest_type=city&children_number=2&page_number=0");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var value = JObject.Parse(response.Content)["results"][1]["priceBreakdown"]["grossPrice"]["value"].ToString();
            return value;
        }

        public static string Name(string apiKey, string destID)
        {

            var client = new RestClient($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=price&adults_number=2&checkin_date=2023-09-27&filter_by_currency=USD&dest_id={destID}&locale=en-gb&checkout_date=2023-09-28&units=imperial&room_number=1&dest_type=city&children_number=2&page_number=0");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var value = JObject.Parse(response.Content)["results"][3]["name"].ToString();
            return value;
        }

        public static string Score(string apiKey, string destID)
        {

            var client = new RestClient($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=price&adults_number=2&checkin_date=2023-09-27&filter_by_currency=USD&dest_id={destID}&locale=en-gb&checkout_date=2023-09-28&units=imperial&room_number=1&dest_type=city&children_number=2&page_number=0");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{apiKey}");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Get(request);
            var reviewScore = JObject.Parse(response.Content)["results"][0]["reviewScore"].ToString();
            return reviewScore;
        }


    }
}

