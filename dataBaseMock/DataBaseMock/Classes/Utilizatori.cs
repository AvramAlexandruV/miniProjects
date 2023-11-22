using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMock.Classes
{
    class Utilizatori
    {
        // cheie primara
        public string EmailUtilizator { get; set; }
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }

        public Utilizatori() {
            EmailUtilizator = "a";
            NumeUtilizator = "b";
            Parola = "c";
        }

        public Utilizatori(string EmailUtilizator, string NumeUtilizator, string Parola) {
            this.EmailUtilizator = EmailUtilizator;
            this.NumeUtilizator = NumeUtilizator;
            this.Parola = Parola;
        }

        public string toString() {
            return "Datele Utlizatorului : " + EmailUtilizator + " " + NumeUtilizator + " " + Parola;
        }

        public string normalizare() {
            return EmailUtilizator + ";" + NumeUtilizator + ";" + Parola;
        }
    }
}
