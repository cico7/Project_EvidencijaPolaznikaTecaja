using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvidencijaPolaznikaTecaja
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //*********************************************************************************//
            //**************************** Podaci za testiranje *******************************//
            //*********************************************************************************//
            DateTime datum_pocetka_tecaja1, datum_pocetka_tecaja2, datum_pocetka_tecaja3;

            //Objekt1 odslušao i položio 
            //Objekt2 odslušao i nije položio
            //Objekt3 još sluša i nije položio

            datum_pocetka_tecaja1 = DateTime.Parse("1900-01-01");
            datum_pocetka_tecaja2 = DateTime.Parse("1900-01-01");
            datum_pocetka_tecaja3 = DateTime.Parse("1900-01-01");

            DateTime datum_zavrsetka_tecaja1 = DateTime.Parse("2000-01-01");
            DateTime datum_zavrsetka_tecaja2 = DateTime.Parse("2000-01-01");
            DateTime datum_zavrsetka_tecaja3 = DateTime.Parse("2030-01-01");

            SviPolaznici PopisPolaznika = new SviPolaznici();
            
            Polaznik Objekt1 = new Polaznik ("Pero", "Perić", "11111111111", datum_pocetka_tecaja1);
            Polaznik Objekt2 = new Polaznik("Ante", "Anić", "22222222222", datum_pocetka_tecaja2);
            Polaznik Objekt3 = new Polaznik("Klara", "Klarić", "33333333333", datum_pocetka_tecaja3);

            Objekt1.DatumZavrsetkaTecaja = datum_zavrsetka_tecaja1;
            Objekt2.DatumZavrsetkaTecaja = datum_zavrsetka_tecaja2;
            Objekt3.DatumZavrsetkaTecaja = datum_zavrsetka_tecaja3;

            Objekt1.UspjesnoPolozenTecaj = true;
            
            //Imam tri objekta koji predstavljaju pojedine polaznike objekt 1,2,3
            //Imam jedan objekt koji sadrži listu svih polaznika i on se zove PopisPolaznika
            //Naziv same klase se  glavnom progrmu obicno koristi samo kod kreiranja objekata ( linije koja ima new)
            //U objekt PopisPolaznika dodajemo pojednine polaznike koristeći metodu DodajPolaznika
            //Metoda nad objektom se zove tako da se napise imeobjekta.imemetode(parametri)

            PopisPolaznika.DodajIspunjenogPolaznika(Objekt1);
            PopisPolaznika.DodajIspunjenogPolaznika(Objekt2);
            PopisPolaznika.DodajIspunjenogPolaznika(Objekt3);

            //*********************************************************************************//
            //*********************************************************************************//
            for ( ; ; ) 
            {
                Console.Clear();

                int OdabranaOpcija = Meni();

                switch (OdabranaOpcija)
                {   
                    case 1: //Gotovo
                        PopisPolaznika.UnesiRucnoNovogPolaznika();
                        break;
                    case 2: //Gotovo
                        PopisPolaznika.AzuriranjePostojecegPolaznika();
                        break;
                    case 3: //Gotovo
                        PopisPolaznika.PostavljanjeDatumaZavrsetkaTecaja();
                        break;
                    case 4: //Gotovo
                        PopisPolaznika.UspjesniZavrsetakTecaja();
                        Console.WriteLine();
                        break;
                    case 5: //Gotovo
                        PopisPolaznika.IspisiSvePolaznike();
                        Console.WriteLine();
                        Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
                        Console.ReadKey();
                        break;
                    case 6://Gotovo
                        PopisPolaznika.AktivniPolaznici();
                        Console.WriteLine();
                        break;
                    case 7://Gotovo
                        PopisPolaznika.PolazniciKojiSuOdslusali_i_NisuPolozili();
                        Console.WriteLine();
                        break;
                    case 8://Gotovo
                        PopisPolaznika.PolazniciKojiSuOdslusali_i_Polozili();
                        Console.WriteLine();
                        break;
                    case 9: //Gotovo
                        PrekidPrograma();
                        break;
                }
            }
        }
        static int Meni() 
        {
            //Metoda za pozivanje Menia na konzolnom prozoru//

            Console.WriteLine("Odaberite jednu od ponuđenih opcija u nastavku: \n");
            Console.WriteLine("<1> # Dodavanje novog polaznika.");
            Console.WriteLine("<2> # Ažuriranje postojećeg polaznika.");
            Console.WriteLine("<3> # Postavljenje datuma završetka tečaja (za određenog polaznika).");
            Console.WriteLine("<4> # Postavljenje podatka o uspješnom završetku tečaja(za određenog polaznika).");
            Console.WriteLine("<5> # Ispis svih polaznika.");
            Console.WriteLine("<6> # Ispis aktivnih polaznika(polaznici za koje tečaj još uvijek traje).");
            Console.WriteLine("<7> # Ispis polaznika koji su odslušali tečaj, ali nisu uspješno položili.");
            Console.WriteLine("<8> # Ispis polaznika koji su odslušali tečaj i uspješno položili.");
            Console.WriteLine("<9> # Prekid rada programa.");
            Console.WriteLine();

            Console.Write("Unesite broj odabrane opcije: ");
            int.TryParse(Console.ReadLine(), out int OdabranaOpcija);

            return OdabranaOpcija;
        }   
        
        static void PrekidPrograma()
        {
            //9. Prekid rada programa
            Console.WriteLine();
            Console.WriteLine("Prekid rada programa!");
            
            Thread.Sleep(1000); //https://stackoverflow.com/questions/91108/how-do-i-get-my-c-sharp-program-to-sleep-for-50-msec

            Environment.Exit(0); //https://stackoverflow.com/questions/12180512/exit-from-a-console-application-in-c-sharp
        }
    }
}
