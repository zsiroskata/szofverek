using System.Collections.Generic;
using System.Threading.Channels;

namespace szoftverek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5.feladat");
            List<Szoftver> szofverek = new();
            var sr = new StreamReader(
                path: @"..\..\..\src\szoftverek.txt",
                encoding: System.Text.Encoding.UTF8
                );

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                var sor = new Szoftver(sr.ReadLine());
                szofverek.Add(sor);
                
            }

            Console.WriteLine("6. feladat");
            for (int i = 0; i < szofverek.Count; i++)
            {
                Console.WriteLine(szofverek[i]);
            }

            Console.WriteLine("\n7.feladat");
            Console.WriteLine($"Összesen:{antiFugg(szofverek)}db");

            Console.WriteLine("\n8.feladat");
            //nincs

            Console.WriteLine("\n9.feladat");


            //        ????
            //      ?     ?
            //           ?
            //          ?         
            //          ?         
            //          ■
            
            foreach (var s in szofverek)
            {
                
                Console.WriteLine($"{s.brutto()}");
            }
            
            //- - - - - - - - main vége - - - - - - - -
        }

        static string antiFugg(List<Szoftver> szoftvers)
        {
            double ert =8.5;
            List<Szoftver> antilista = new();
          
            foreach (var gep in szoftvers)
            {
                if (gep.Ertekeles > ert && gep.Kategoria == "antivírus")
                {
                   antilista.Add(gep);
                }
            }
            return $"{antilista.Count}";
        }



    }
}