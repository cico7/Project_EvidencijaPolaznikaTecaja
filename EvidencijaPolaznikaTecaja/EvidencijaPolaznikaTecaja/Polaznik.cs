using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaPolaznikaTecaja
{
    class Polaznik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public DateTime DatumPocetkaTecaja { get; set; }
        public DateTime DatumZavrsetkaTecaja { get; set; }
        public Boolean UspjesnoPolozenTecaj { get; set; }


        
        public Polaznik(string ime, string prezime, string oib, DateTime datum_pocetka_tecaja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Oib = oib;
            this.DatumPocetkaTecaja = datum_pocetka_tecaja;
            this.DatumZavrsetkaTecaja = DateTime.MaxValue;
            this.UspjesnoPolozenTecaj = false;
        }
        
        
       
        

    }
}
