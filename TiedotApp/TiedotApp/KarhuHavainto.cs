using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedotApp
{
    public class KarhuHavainto
    {
        public DateTime Havaintopaiva { get; set; }
        public string Havaintopaikka { get; set; }
        public string Nahty { get; set; }
        public int JaljenPituus { get; set; }
        public string Kuvaus { get; set; }
    }
}
