using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    class Meccs
    {
        public string HazaiCsapat { get; set; }
        public string IdegenCsapat { get; set; }
        public int HazaiPont { get; set; }
        public int IdegenPont { get; set; }
        public string Helyszín { get; set; }
        public DateTime Időpont { get; set; }

        public Meccs(string sor)
        {
            string[] s = sor.Split(';');
            HazaiCsapat = s[0];
            IdegenCsapat = s[1];
            HazaiPont = int.Parse(s[2]);
            IdegenPont = int.Parse(s[3]);
            Helyszín = s[4];
            Időpont = DateTime.Parse(s[5]);
        }
    }
}
