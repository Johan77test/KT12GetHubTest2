using System;
using System.Collections.Generic;
using System.Text;

namespace PingvinArv
{
    public class Hund
    {
        private int id;
        public Hund(string forNamn, string efterNamn, double vikt)
        {
            id = 1;
            ForNamn = forNamn;
            EfterNamn = efterNamn;
            Vikt = vikt;
        }

        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public double Vikt { get; set; }

    }
}
