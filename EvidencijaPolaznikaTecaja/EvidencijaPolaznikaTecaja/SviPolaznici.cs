using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaPolaznikaTecaja
{
    class SviPolaznici
    {
        public List<Polaznik> PolazniciLista { get; set; } = new List<Polaznik>();

        public void DodajIspunjenogPolaznika(Polaznik NoviPolaznik) 
        {
            this.PolazniciLista.Add(NoviPolaznik);
        }

        public void UnesiRucnoNovogPolaznika()
        {
            //1. Dodavanje novog polaznika//
            Console.Write("Napisite IME novog polaznika: ");
            string ime = Console.ReadLine();
            Console.Write("Napisite PREZIME novog polaznika: ");
            string prezime = Console.ReadLine();
            Console.Write("Napisite OIB novog polaznika: ");
            string oib = Console.ReadLine();
            Console.Write("Napisite DATUM POCETKA TECAJA: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime datum_pocetka_tecaja);

            Polaznik ObjektNoviPolaznik = new Polaznik(ime, prezime, oib, datum_pocetka_tecaja);
            this.PolazniciLista.Add(ObjektNoviPolaznik);
        }
        public void AzuriranjePostojecegPolaznika()
        {
            //2. Ažuriranje postojećeg polaznika//

            Console.WriteLine("Postojeci polaznici su: ");
            IspisiSvePolaznike();
            Console.WriteLine("Kojeg zelite promjeniti: ");
            int.TryParse(Console.ReadLine(), out int OdabraniPolaznik);
            Console.WriteLine("Odabrali ste: ");
            Console.WriteLine(
                                "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                , OdabraniPolaznik
                                , this.PolazniciLista[OdabraniPolaznik - 1].Prezime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Ime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Oib
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumPocetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumZavrsetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                );

            Console.Write("Napisite IME novog polaznika: ");
            string ime = Console.ReadLine();
            this.PolazniciLista[OdabraniPolaznik - 1].Ime = ime;

            Console.Write("Napisite PREZIME novog polaznika: ");
            string prezime = Console.ReadLine();
            this.PolazniciLista[OdabraniPolaznik - 1].Prezime = prezime;

            Console.Write("Napisite OIB novog polaznika: ");
            string oib = Console.ReadLine();
            this.PolazniciLista[OdabraniPolaznik - 1].Oib = oib;

            Console.Write("Napisite DATUM POCETKA TECAJA: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime datum_pocetka_tecaja);
            this.PolazniciLista[OdabraniPolaznik - 1].DatumPocetkaTecaja = datum_pocetka_tecaja;

            Console.ReadKey();
        }

        public void PostavljanjeDatumaZavrsetkaTecaja()
        {
            //3. Postavljenje datuma završetka tečaja (za određenog polaznika)

            Console.WriteLine("Postojeci polaznici su: ");
            IspisiSvePolaznike();
            Console.WriteLine("Odaberite redni broj polaznika kome zelite dodati datum zavrsetka tecaja: ");
            int.TryParse(Console.ReadLine(), out int OdabraniPolaznik);
            Console.WriteLine("Odabrali ste: ");
            Console.WriteLine(
                                "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                , OdabraniPolaznik
                                , this.PolazniciLista[OdabraniPolaznik - 1].Prezime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Ime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Oib
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumPocetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumZavrsetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                );

            Console.Write("Napisite DATUM ZAVRSETKA TECAJA: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime datum_zavrsetka_tecaja);
            this.PolazniciLista[OdabraniPolaznik - 1].DatumZavrsetkaTecaja = datum_zavrsetka_tecaja;
            Console.WriteLine();

            Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
            Console.ReadKey();

        }
        public void UspjesniZavrsetakTecaja()
        {
            //4. Postavljenje podatka o uspješnom završetku tečaja(za određenog polaznika)

            Console.WriteLine("Postojeci polaznici su: ");
            IspisiSvePolaznike();
            Console.WriteLine();
            Console.Write("Odaberite redni broj polaznika kome zelite dodati podatak da je uspješno POLOŽIO: ");
            int.TryParse(Console.ReadLine(), out int OdabraniPolaznik);
            Console.WriteLine();
            Console.WriteLine("Odabrali ste polaznika: ");
            Console.WriteLine(
                                "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                , OdabraniPolaznik
                                , this.PolazniciLista[OdabraniPolaznik - 1].Prezime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Ime
                                , this.PolazniciLista[OdabraniPolaznik - 1].Oib
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumPocetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].DatumZavrsetkaTecaja
                                , this.PolazniciLista[OdabraniPolaznik - 1].UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                );
            Console.WriteLine();
            Console.Write("Upisite # -->>> D(Položio) ili N(Nije Položio <<<-- # : ");
            string UspjesnoPolozenTecaj = Console.ReadLine();
            this.PolazniciLista[OdabraniPolaznik - 1].UspjesnoPolozenTecaj = UspjesnoPolozenTecaj=="D" ? true:false;
            Console.WriteLine();

            Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
            Console.ReadKey();

        }
        public void IspisiSvePolaznike()
        {
            //5. Ispis svih polaznika
            int brojac = 0;
            foreach (Polaznik PolaznikZaIspis in this.PolazniciLista)
            {
                brojac++;
                Console.Write(
                                    "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} "
                                    , brojac
                                    , PolaznikZaIspis.Prezime
                                    , PolaznikZaIspis.Ime
                                    , PolaznikZaIspis.Oib
                                    , PolaznikZaIspis.DatumPocetkaTecaja
                                    , PolaznikZaIspis.DatumZavrsetkaTecaja
                                    );

                //https://www.c-sharpcorner.com/article/change-console-foreground-and-background-color-in-c-sharp/
                Console.ForegroundColor = PolaznikZaIspis.UspjesnoPolozenTecaj ? ConsoleColor.Green: ConsoleColor.Red;
                Console.WriteLine(PolaznikZaIspis.UspjesnoPolozenTecaj ? "Položio" : "Nije Položio");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        public void AktivniPolaznici()
        {
            //6. Ispis aktivnih polaznika(polaznici za koje tečaj još uvijek traje)


            int brojac = 0;
            foreach (Polaznik Aktpolaznik in this.PolazniciLista)
            {
                brojac++;
                if (Aktpolaznik.DatumZavrsetkaTecaja > DateTime.Today)
                {
                    Console.WriteLine(
                                    "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                    , brojac
                                    , Aktpolaznik.Prezime
                                    , Aktpolaznik.Ime
                                    , Aktpolaznik.Oib
                                    , Aktpolaznik.DatumPocetkaTecaja
                                    , Aktpolaznik.DatumZavrsetkaTecaja
                                    , Aktpolaznik.UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                    );
                }
            }
            Console.WriteLine();
            Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
            Console.ReadKey();


        }
        public void PolazniciKojiSuOdslusali_i_NisuPolozili()
        {
            //7. Ispis polaznika koji su odslušali tečaj, ali nisu uspješno položili

            int brojac = 0;
            foreach (Polaznik Aktpolaznik in this.PolazniciLista)
            {
                brojac++;
                if (Aktpolaznik.DatumZavrsetkaTecaja <= DateTime.Today && Aktpolaznik.UspjesnoPolozenTecaj == false)
                {
                    Console.WriteLine(
                                    "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                    , brojac
                                    , Aktpolaznik.Prezime
                                    , Aktpolaznik.Ime
                                    , Aktpolaznik.Oib
                                    , Aktpolaznik.DatumPocetkaTecaja
                                    , Aktpolaznik.DatumZavrsetkaTecaja
                                    , Aktpolaznik.UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                    );
                }
            }
            Console.WriteLine();
            Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
            Console.ReadKey();

        }
        public void PolazniciKojiSuOdslusali_i_Polozili()
        {
            //8. Ispis polaznika koji su odslušali tečaj i uspješno položili

            int brojac = 0;
            foreach (Polaznik AktpolaznikPolozio in this.PolazniciLista)
            {
                brojac++;
                if (AktpolaznikPolozio.DatumZavrsetkaTecaja <= DateTime.Today && AktpolaznikPolozio.UspjesnoPolozenTecaj == true)
                {
                    Console.WriteLine(
                                    "{0}. {1}, {2} Oib: {3} {4:dd.MM.yyyy}-{5:dd.MM.yyyy} {6}"
                                    , brojac
                                    , AktpolaznikPolozio.Prezime
                                    , AktpolaznikPolozio.Ime
                                    , AktpolaznikPolozio.Oib
                                    , AktpolaznikPolozio.DatumPocetkaTecaja
                                    , AktpolaznikPolozio.DatumZavrsetkaTecaja
                                    , AktpolaznikPolozio.UspjesnoPolozenTecaj ? "Položio" : "Nije Položio"
                                    );
                }
            }
            Console.WriteLine();
            Console.Write("Za nastavak izvođenja programa pritisnite bilo koju tipku!");
            Console.ReadKey();

        }
    }
}
