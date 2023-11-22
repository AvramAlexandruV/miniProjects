using DataBaseMock.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMock.Forms
{
    class Data
    {
        DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);

        public List<Utilizatori> utilizatori = new List<Utilizatori>();
        public List<Rezultate> rezultate = new List<Rezultate>();
        public List<Itemi> itemi = new List<Itemi>();

        public void CitireUtilizatori()
        {
            string utilizator;
             StreamReader sr = new StreamReader(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Utilizatori.txt"));
            
            while ((utilizator = sr.ReadLine()) != null) {
                string[] date = utilizator.Split(';');
                utilizatori.Add(new Utilizatori(date[0], date[1], date[2]));
            }

            sr.Close();
        }

        public void ScriereUtilizator(Utilizatori utilizator) {
            StreamWriter fs = new StreamWriter(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Utilizatori.txt"), append: true);
            fs.WriteLine();
            fs.Write(utilizator.normalizare());

            fs.Close();
            this.CitireUtilizatori();

        }

        public void CitireRezultate()
        {
            string rezultat;
            StreamReader sr = new StreamReader(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Rezultate.txt"));

            while ((rezultat = sr.ReadLine()) != null)
            {
                string[] date = rezultat.Split(';');
                rezultate.Add(new Rezultate(Int32.Parse(date[0]), Int32.Parse(date[1]), date[2], Int32.Parse(date[3])));
            }

            sr.Close();
        }

        public void ScriereRezultat(Rezultate rezultat)
        {
            StreamWriter fs = new StreamWriter(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Rezultate.txt"), append: true);
            fs.WriteLine();
            fs.Write(rezultat.normalizare(this.rezultate.Last().idRezultat));
            
            fs.Close();
            this.CitireRezultate();
        }

        public void CitireItemi()
        {
            string item;
            StreamReader sr = new StreamReader(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Itemi.txt"));

            while ((item = sr.ReadLine()) != null)
            {
                string[] date = item.Split(';');
                itemi.Add(new Itemi(Int32.Parse(date[0]), date[1], date[2], date[3], date[4], Int32.Parse(date[5]), Int32.Parse(date[6])));
            }

            sr.Close();
        }

        public void ScriereItem(Itemi item)
        {
            StreamWriter fs = new StreamWriter(Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName, "./Data/Itemi.txt"), append: true);
            fs.WriteLine();
            fs.Write(item.normalizare(this.itemi.Last().idItem));

            fs.Close();
            this.CitireItemi();
        }
    }

   
}
