using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesekxd
{
    class Sportolok
    {
        public string NÉV { get; set; }

        public string Első { get; set; }

        public string Utolsó { get; set; }

        public int Súly { get; set; }

        public int Magasság { get; set; }
    
        public Sportolok (string sor)
        {
            string[] t = sor.Split(';');
            NÉV = t[0];
            Első = t[1];
            Utolsó = t[2];
            Súly = int.Parse(t[3]);
            Magasság = int.Parse(t[4]);
        }
    }
}
