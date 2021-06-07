using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kosar2004
{
    class kosar2004
    {
        static void Main(string[] args)
        {
            //2.
            List<Meccs> meccsek = new List<Meccs>();
            foreach (var sor in File.ReadAllLines("eredmenyek.csv").Skip(1))
            {
                meccsek.Add(new Meccs(sor));
            }

            //3.
            Console.WriteLine($"3. feladat: Real Madrid: " +
                $"Hazai: {meccsek.Where(x => x.HazaiCsapat.Contains("Real Madrid")).Count()}, " +
                $"Idegen: {meccsek.Where(x => x.IdegenCsapat.Contains("Real Madrid")).Count()}");

            Console.ReadKey();
        }
    }
}
