using Newtonsoft.Json;
using System;
using System.IO;
namespace Movie_DB.Commands.Admin
{
    public class JSONController
    {
        public static void ReturnJSON(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine();
            Console.WriteLine(json, Formatting.Indented);
        }

        public static void SaveToFile(Object obj)
        {
            string url = "../../Data/saved.json";
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(url, json);
        }

        //public static Object LoadFromFile(string  url)
        //{
        //    Object objectFromFile = 
        //}

        // var json = JsonConvert.DeserializeObject(obj);
    }
}
