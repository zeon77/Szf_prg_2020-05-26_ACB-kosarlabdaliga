﻿using System;
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

            //4.
            Console.WriteLine($"4. feladat: Volt döntetlen: {(meccsek.Any(x => x.Döntetlen == true) ? "igen" : "nem")}");

            //5.
            Console.WriteLine($"5. feladat: barcelonai csapat neve: {meccsek.Where(x => x.HazaiCsapat.ToLower().Contains("barcelona")).First().HazaiCsapat}");

            Console.ReadKey();
        }
    }
}
