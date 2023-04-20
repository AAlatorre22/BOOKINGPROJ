using Newtonsoft.Json.Linq;

namespace BOOKINGPROJ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();
            


        }
    }
}