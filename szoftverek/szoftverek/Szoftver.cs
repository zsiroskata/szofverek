using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace szoftverek
{
    internal class Szoftver
    {
        public int Azonosíto { get; set; }
        public string NevEsVerzio{ get; set; }
        public bool Licenc { get; set; }
        public string Oprendszer { get; set; }
        public string Kategoria { get; set; }
        public double Ertekeles { get; set; }
        public double Netto { get; set; }
        public int Adokulcs { get; set; }
        
        public Szoftver(string sor) {
            string[] adat = sor.Split("|");
            Azonosíto = int.Parse(adat[0]);
            NevEsVerzio = adat[1];
            Licenc = adat[2] == "fizetős";
            Oprendszer = adat[3];
            Kategoria = adat[4];
            Ertekeles = Convert.ToDouble(adat[5]);
            Netto = Convert.ToDouble(adat[6]);
            Adokulcs = int.Parse(adat[7]);
            Adokulcs = int.Parse(adat[7]);
        }
        public override string ToString()
        {
            return $"Azonosító: {Azonosíto}, név és verziószám: {NevEsVerzio}, licenc típus: {Licenc}, operációs rendszerek: {Oprendszer}, kategória: {Kategoria}, felhasználói értékelés: {Ertekeles}, nettó ár: {Netto}, adókulcs: {Adokulcs}";
        }

        public double brutto()
        {
            return Netto * (Adokulcs / 100);
        }

    }
}
