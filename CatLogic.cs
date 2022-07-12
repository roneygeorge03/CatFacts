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

        public List<Fact> Getallfact()
        {
            List<Fact> source = new List<Fact>();
            using (StreamReader r = new StreamReader("CatFacts.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<Fact>>(json);
            }
            return source;

            //uncomment below code if you want to get it as a paragraph
            //int i = 0;
            //string allFacts = "";
            //while (i < source.Count)
            //{
            //    allFacts = allFacts + source[i].fact ;
            //    i++;
            //}
            //return allFacts;

        }
        public List<Fact> AddFact(Fact ft)
        {

            List<Fact> source = new List<Fact>();
            using (StreamReader r = new StreamReader("CatFacts.json"))
            {
                string json = r.ReadToEnd();
                source = JsonSerializer.Deserialize<List<Fact>>(json);
            }
            ft.length = ft.fact.Length;
            source.Add(ft);
            string jsonString = JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter("CatFacts.json"))
            {
                outputFile.WriteLine(jsonString);
            }
            return source;
        }      

    }
}


