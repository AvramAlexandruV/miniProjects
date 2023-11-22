using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMock.Classes
{
    class Rezultate
    {
        // cheie primara
        public int idRezultat {get;set;}
        public int TipJoc { get; set; }
        public string EmailUtilizator { get; set; }
        public int PunctajJoc { get; set; }

        public Rezultate() {
            idRezultat = -1;
            TipJoc = -1;
            EmailUtilizator = "";
            PunctajJoc = 0;
        }

        public Rezultate(int idRezultat, int TipJoc, string EmailUtilizator, int PunctajJoc) {
            this.idRezultat = idRezultat;
            this.TipJoc = TipJoc;
            this.EmailUtilizator = EmailUtilizator;
            this.PunctajJoc = PunctajJoc;
        }

        override public string ToString() {
            return "Rezultat : " + idRezultat + " " + TipJoc + " " + EmailUtilizator + " " + PunctajJoc;
        }

        public string normalizare(int id)
        {
            return (id + 1) + ";" + TipJoc + ";" + EmailUtilizator + ";" + PunctajJoc;
        }
    }
}
