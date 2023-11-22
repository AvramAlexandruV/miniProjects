using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMock.Classes
{
    class Itemi
    {
        public int idItem { get; set; }
        public string EnuntItem { get; set; }
        public string Raspuns1 { get; set; }
        public string Raspuns2 { get; set; }
        public string Raspuns3 { get; set; }
        //  1 || 2 || 3 -> legat de rasp corect
        public int RaspunsCorect { get; set; }
        public int PunctajItem { get; set; }

        public Itemi()
        {
            idItem = -1;
            EnuntItem = "";
            Raspuns1 = "";
            Raspuns2 = "";
            Raspuns3 = "";
            RaspunsCorect = -1;
            PunctajItem = -1;
        }

        public Itemi(int idItem, string EnuntItem, string Raspuns1, string Raspuns2, string Raspuns3, int RaspunsCorect, int PunctajItem) {
            this.idItem = idItem;
            this.EnuntItem = EnuntItem;
            this.Raspuns1 = Raspuns1;
            this.Raspuns2 = Raspuns2;
            this.Raspuns3 = Raspuns3;
            this.RaspunsCorect = RaspunsCorect;
            this.PunctajItem = PunctajItem;
        }

        override public string ToString() {
            return "Item : " + idItem + " " + EnuntItem + " " + Raspuns1 + " " + Raspuns2 + " " + Raspuns3 + " " + RaspunsCorect + " " + PunctajItem;
        }

        public string normalizare(int id)
        {
            return (id + 1) + ";" + EnuntItem + ";" + Raspuns1 + ";" + Raspuns2 + ";" + Raspuns3 + ";" + RaspunsCorect + ";" + PunctajItem;
        }
    }
}
