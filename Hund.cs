using System;
using System.Collections.Generic;
using System.Text;

namespace PingvinArv
{
    public class Hund
    {
        public Hund(string forNamn, string efterNamn, double vikt)
        {            
            ForNamn = forNamn;
            EfterNamn = efterNamn;
            Vikt = vikt;
        }

        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public double Vikt { get; set; }

    }
}
