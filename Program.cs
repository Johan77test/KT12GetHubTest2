using System;

namespace PingvinArv
{
    class Program
    {
        static void Main(string[] args)
        {
            Pingvin pingvin1 = new Pingvin("Pingu", "Pingvin", 1);
            Pingvin pingvin2 = new Pingvin("Lani", "Pingvin", 2);
            Pingvin pingvin3 = new Pingvin("BigZ", "Pingvin", 4);

            PingvinRegister pingvinLista = new PingvinRegister();
            pingvinLista.Add(pingvin1);
            pingvinLista.Add(pingvin2);
            pingvinLista.Add(pingvin3);

            foreach (Pingvin enPingvin in pingvinLista)
            {
                Console.WriteLine(enPingvin.ForNamn);
            }

        }
    }
}
