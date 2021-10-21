using System;
using System.Collections.Generic;
using System.Text;

namespace PingvinArv
{
    public class Hund
    {
        private int id;
        public Hund(string forNamn, string eftNamn, double vikt)
        {
            id = 4;
            ForNamn = forNamn;
            EfterNamn = eftNamn;
            Vikt = vikt;
        }

        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public double Vikt { get; set; }

    }
}
