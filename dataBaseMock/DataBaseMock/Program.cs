using DataBaseMock.Classes;
using DataBaseMock.Forms;
using System;

namespace DataBaseMock
{
    class Program
    {
        static void Main(string[] args)
        {
            Data dataBase = new Data();

            dataBase.CitireUtilizatori();
            dataBase.CitireRezultate();
            dataBase.CitireItemi();

            foreach (Utilizatori u in dataBase.utilizatori) {
                Console.WriteLine(u.toString());
            }

            Utilizatori tmp = new Utilizatori("alexav20044@gmail.com", "Alex Avram", "alex1234");
            dataBase.ScriereUtilizator(tmp);

            Console.WriteLine();
            Console.WriteLine("---- Dupa inserare ----");
            foreach (Utilizatori u in dataBase.utilizatori)
            {
                Console.WriteLine(u.toString());
            }
        }
    }
}
