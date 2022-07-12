//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;
using System.Net.Http;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Text.Json;


namespace CatFacts
{
    public class CatLogic
    {
        public string GetRndmFact(int id)
        {
            List<Fact> source = new List<Fact>();
            using (StreamReader r = new StreamReader("CatFacts.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<Fact>>(json);
            }

            Random rnd = new Random();
            int r1 = rnd.Next(source.Count);
            return source[r1].fact;
        }

        public string Getallfact()
        {
            List<Fact> source = new List<Fact>();
            using (StreamReader r = new StreamReader("CatFacts.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<Fact>>(json);
            }

            int i = 0;
            string allFacts = "";
            while (i < source.Count)
            {
                allFacts = allFacts + source[i].fact + Environment.NewLine;
                i++;
            }
            return allFacts;

        }
        public string AddFact()
        {

            List<Fact> source = new List<Fact>();
            using (StreamReader r = new StreamReader("CatFacts.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<Fact>>(json);
            }

            string jsonString = JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter("dataReady.json"))
            {
                outputFile.WriteLine(jsonString);
            }
            return "dataReady.json";
        }      

    }
}


