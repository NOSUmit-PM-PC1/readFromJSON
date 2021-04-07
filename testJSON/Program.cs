using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.json");
            string strJSON = sr.ReadToEnd();
            sr.Close();

            JObject jObject = JObject.Parse(strJSON);

            JToken tokGroup = jObject.GetValue("group");
            Console.WriteLine("Группа " + tokGroup.ToString());

            JToken tokStudents = jObject.GetValue("students");
            foreach (var st in tokStudents)
            {
                Console.WriteLine(st.SelectToken("learn[0].subject").ToString());
            }

        }
    }
}
