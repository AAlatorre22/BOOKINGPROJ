using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace BOOKINGPROJ
{
    public class Cities
    {


        var client = new RestClient("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-us");
        var request = new RestRequest();
        Request.AddHeader("X-RapidAPI-Key", "7b5c999cdcmsh26c0a24ac75c4d0p17ad3bjsn03f1cbc956be");
            request.AddHeader("X-RapidAPI-Host", "booking-com.p.rapidapi.com");
            var response = client.Execute(request);



    }
}
