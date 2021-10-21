using System;
using System.Collections.Generic;
using System.Text;

namespace PingvinArv
{
    public class Hund
    {
        private int id;
        public Hund(string forNamn, string eNamn, double vikt)
        {
            id = 4;
            ForNamn = forNamn;
            EfterNamn = eNamn;
            Vikt = vikt;
        }

        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public double Vikt { get; set; }

    }
}
