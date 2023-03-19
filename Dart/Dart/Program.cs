using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Klasa> tablica_strzaly = new List<Klasa>();
            for (int i=1;i<=20;i++)
            {
                Klasa nowyobiekt = new Klasa($"S{i}",i);
                tablica_strzaly.Add(nowyobiekt);
            }
            for(int i = 1; i <= 20; i++)
            {
                Klasa nowyobiekt = new Klasa($"D{i}", i*2);
                tablica_strzaly.Add(nowyobiekt);
            }
            for (int i = 1; i <= 20; i++)
            {
                Klasa nowyobiekt = new Klasa($"T{i}", i * 3);
                tablica_strzaly.Add(nowyobiekt);
            }
            Klasa outereye = new Klasa("outereye", 25);
            tablica_strzaly.Add(outereye);

            Klasa bullseye = new Klasa("bullseye", 50);
            tablica_strzaly.Add(bullseye);

            Klasa tablica = new Klasa();

            //var kot = tablica.Pierwszy(4, tablica_strzaly);
            //var kot = tablica.Drugi(103, tablica_strzaly);
            var kot = tablica.Trzeci(161, tablica_strzaly);
            int a = 0;
            foreach (var item in kot)
            {
                Console.Write(item.polenatarczy.ToString()+" ");
                Console.Write(item.Wartosc.ToString()+" ");
                a++;
                if (a % 3 == 0) { Console.WriteLine(); }

            }
            
             
            


        }
    }
}
