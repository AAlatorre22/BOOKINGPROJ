using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOOKINGPROJ
{
    public class KeyHolder
    {
        public static string GetKey() 
        { 
        string key = File.ReadAllText("appsettings.json");
        string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();
        //string apiCall = $"https://booking-com.p.rapidapi.com/v1/hotels/data?hotel_id=1377073&locale=en-gb";

            return apiKey;
        }
    }
}
