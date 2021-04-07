using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace testSimpleJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("example.json");
            string strJson = file.ReadToEnd();
            file.Close();

            JObject objectJSON = JObject.Parse(strJson);

            JToken tokName = objectJSON.GetValue("firstName");
            Console.WriteLine(tokName.ToString());

            JToken tokCity = objectJSON.SelectToken("address.city");
            Console.WriteLine(tokCity.ToString());

            JToken tokPhones = objectJSON.GetValue("phoneNumbers");
            foreach (var phone in tokPhones)
                Console.WriteLine(phone);
        }
    }
}
