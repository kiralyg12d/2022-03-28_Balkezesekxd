using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesekxd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportolok> sportoloks = new List<Sportolok>();
            foreach (var sor in File.ReadAllLines("baélezesek.csv").Skip(1))
            {
                sportoloks.Add(new Sportolok(sor));
            }
            Console.WriteLine($"3.feladat:{sportoloks.Count}");
        }
    }
}
