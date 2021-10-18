using System;
using System.Collections.Generic;
using System.Text;

namespace PingvinArv
{
    public class Pingvin
    {
        public static string artBeteckning = "A001";
        public Pingvin(string forNamn, string efterNamn, double vikt)
        {            
            ForNamn = forNamn;
            EfterNamn = efterNamn;
            Vikt = vikt;
        }

        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public double Vikt { get; set; }
        
        public string ArtBet
        {
            get { return artBeteckning; }  //läser av objektets artbeteckning          
        }
    }
}
