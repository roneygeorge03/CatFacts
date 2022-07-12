using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatFacts
{
    public class Fact
    {
       // public int id { get; set; }
        public string fact { get; set; }
        public int length { get; set; }       
    }

    public class Root
    {
        public List<Fact> facts { get; set; }
    }

}
