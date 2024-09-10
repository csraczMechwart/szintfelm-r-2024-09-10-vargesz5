using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class Feladat
    {
        public List<merkozesek> adatok;
        public List<string> csapatnev;
        public Feladat(string filename)
        {
            adatok = new();
            foreach (var item in File.ReadAllLines(filename, Encoding.UTF8).Skip(1))
            {
                string[] parts = item.Split(" ");
                int fordulo = Convert.ToInt32(parts[0]);
                int hazaigol = Convert.ToInt32(parts[1]);
                int vendeggol = Convert.ToInt32(parts[2]);
                int hazaifelidogol = Convert.ToInt32(parts[3]);
                int vendegfelidogol = Convert.ToInt32(parts[4]);
                string hazainev = parts[5];
                string vendegnev = parts[6];
                merkozesek uj = new(fordulo, hazaigol, vendeggol, hazaifelidogol, vendegfelidogol, hazainev, vendegnev);
                adatok.Add(uj);
            }
        }
        public void Feladat1()
        {
            Console.Write("Adj meg egy forduló számot: ");
            int forduloszama = Convert.ToInt32(Console.ReadLine());
            var forduloadat = adatok.Where(x => x.Fordulo == forduloszama).ToList();
            foreach (var item in forduloadat)
            {
                Console.WriteLine($"{item.Hazainev} {item.Vendegnev}: {item.Hazaigol}-{item.Vendeggol} ({item.Hazaifelidogol}-{item.Vendegfelidogol})");
            }
        }
        public void Feladat2()
        {
            foreach (var item in adatok)
            { 
                if(item.Hazaifelidogol < item.Vendegfelidogol && item.Hazaigol> item.Vendeggol)
                {
                    Console.WriteLine($"Forduló: {item.Fordulo} GyőztesCsapat: {item.Hazainev}");
                }
                if (item.Hazaifelidogol > item.Vendegfelidogol && item.Hazaigol < item.Vendeggol)
                {
                    Console.WriteLine($"Fordulo: {item.Fordulo} GyőztesCsapat: {item.Vendegnev}");
                }
            }
        }
        public void Feladat3()
        {
            Console.Write("Adj meg egy csapatnevet: ");
            string nev = Console.ReadLine();
            csapatnev.Add( nev );
        }

    }
}
