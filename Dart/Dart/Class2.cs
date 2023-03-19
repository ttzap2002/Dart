/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dart
{
    public class Tablica
    {
        int liczbarzutow = 0;
        List<Klasa> obiekty = new List<Klasa>();

        public Tablica(int liczbarzutow)
        {
            this.Liczbarzutow = liczbarzutow;
        }

        public int Liczbarzutow { get => liczbarzutow; set => liczbarzutow = value; }

        public void DodajStrzal(Klasa strzal)
        {
            obiekty.Add(strzal);
            Liczbarzutow++;
        }


        public List<Klasa> Pierwszy(int iledokonca, List<Klasa> lista)
        {
            List<Klasa> pierwszyrzut = new List<Klasa>();
         
            foreach (Klasa obiekt in lista)
            {
                if (obiekt.wartosc == iledokonca)
                {
                    pierwszyrzut.Add(obiekt);
                }
            }
            return pierwszyrzut;
        }

        public List<Klasa> Drugi(int iledokonca, List<Klasa> lista)
        {
            List<Klasa> drugirzut = new List<Klasa>();
            for(int i=1; i<iledokonca; i++) 
            {
                var lista1 = Pierwszy(i, lista);
                foreach(Klasa obiekt in lista1) 
                {
                    int wynik = iledokonca - obiekt.wartosc;
                    if (wynik == 0) { continue; }

                    foreach(Klasa klasa1 in lista) 
                    {

                        if(klasa1.wartosc == wynik) 
                        {
                            drugirzut.Add(obiekt);
                            drugirzut.Add(klasa1);
                            Console.Write((obiekt.polenatarczy).ToString()+ " ");
                            Console.Write((obiekt.wartosc).ToString()+ " ");
                            Console.Write((klasa1.polenatarczy).ToString()+ " ");
                            Console.Write((klasa1.wartosc).ToString() + " ");
                            Console.WriteLine();
                        }
                    }
                   
                }

            }

            return drugirzut;
        }




        private List<int> licztablice(List<Klasa> lista) 
        {
            List<int> sumawszystkich = new List<int>();
            int a = 0;
            int suma = 0;
            foreach(Klasa klasa in lista) 
            {
                suma = suma + klasa.wartosc;
                a++;
                if (a % 2 == 0) 
                {
                    suma = 0;
                    sumawszystkich.Add(suma);  
                }
            }
            return sumawszystkich;
        }


        public List<Klasa> Trzeci(int iledokonca, List<Klasa> lista)
        {
            List<Klasa> trzecirzut = new List<Klasa>();
            for (int i = 1; i < iledokonca; i++)
            {
                var lista2 = Drugi(i, lista);
                var tablicazsuma = licztablice(lista2);

                int a = 1;
                foreach (Klasa obiekt in lista2)
                {
                    if (a % 2 ==0) ;
                    int wynik = iledokonca - obiekt.wartosc;
                    if (wynik == 0) { continue; }
                    foreach (Klasa klasa1 in lista)
                    {
                        if (klasa1.wartosc == wynik)
                        {
                            trzecirzut.Add(obiekt);

                            trzecirzut.Add(klasa1);
                            Console.Write((obiekt.polenatarczy).ToString() + " ");
                            Console.Write((obiekt.wartosc).ToString() + " ");
                            Console.Write((klasa1.polenatarczy).ToString() + " ");
                            Console.Write((klasa1.wartosc).ToString() + " ");
                            Console.WriteLine();
                        }
                    }

                }

            }
            return trzecirzut;
        }

    }
}
*/