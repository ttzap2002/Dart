using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dart
{
    public class Klasa
    {
        public string polenatarczy;
        public int wartosc;


        public Klasa()
        {
    
        }
        public Klasa(string polenatarczy, int wartosc)
        {
            this.Polenatarczy = polenatarczy;
            this.Wartosc = wartosc;
        }




        public string Polenatarczy { get => polenatarczy; set => polenatarczy = value; }
        public int Wartosc { get => wartosc; set => wartosc = value; }

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
            for (int i = 1; i <=60; i++)
            {
                var lista1 = Pierwszy(i, lista);
                foreach (Klasa obiekt in lista1)
                {
                    int wynik = iledokonca - obiekt.wartosc;
                    if (wynik == 0) { continue; }

                    foreach (Klasa klasa1 in lista)
                    {

                        if (klasa1.wartosc == wynik)
                        {
                            drugirzut.Add(obiekt);
                            drugirzut.Add(klasa1);
                            
                        }
                    }

                }

            }

            return drugirzut;
        }





        public List<Klasa> Trzeci(int iledokonca, List<Klasa> lista)
        {
            List<Klasa> trzecirzut = new List<Klasa>();
            for (int i = 2; i <= 120; i++)
            {
                var lista2 = Drugi(i, lista);
                if (lista2.Count == 0) {continue;}
                int a = 1;
                int wynik = iledokonca-(lista2[a - 1].Wartosc + lista2[a].Wartosc);
                foreach (Klasa obiekt in lista2)
                { 
                    if (a % 2 == 0)
                    {
                      
                        foreach (Klasa klasa1 in lista)
                        { 
                            if (klasa1.wartosc == wynik)
                            {
                                trzecirzut.Add(lista2[a-2]);
                                trzecirzut.Add(lista2[a-1]);
                                trzecirzut.Add(klasa1);
                                
                                
                            }
                        }
                    }
                    a++;
                }    
            }
            
            return trzecirzut;
        }




    }
}
