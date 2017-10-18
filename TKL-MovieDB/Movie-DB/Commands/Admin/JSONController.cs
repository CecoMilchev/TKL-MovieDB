using Models.Framework;
using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

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

        public static Genre[] ReadGenresFromJSON()
        {
            var url = "../../Data/saved.json";
            var json = File.ReadAllText(url);
            var jsonObject = JObject.Parse(json);
            int count = int.Parse(jsonObject.Children().FirstOrDefault(C => C.Path == "count").ToString());
            Genre[] genres = new Genre[count];

            return genres;
        }
    }
}
