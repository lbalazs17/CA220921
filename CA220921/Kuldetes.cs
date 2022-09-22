using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220921
{
    internal class Kuldetes
    {
        public string Kod { get; set; }
        public DateOnly Datum { get; set; }
        public string SikloNeve { get; set; }
        private int KuldetesNapok { get; set; }
        private int KuldetesOra { get; set; }
        public int KuldetesHossza => KuldetesNapok * 24 + KuldetesOra;
        public string LandolasHelye { get; set; }
        public int Legenyseg { get; set; }

        public Kuldetes(string fileEgysOra)
        {
            string[] v = fileEgysOra.Split(";");
            Kod = v[0];
            Datum = DateOnly.Parse(v[1]);
            SikloNeve = v[2];
            KuldetesNapok = int.Parse(v[3]);
            KuldetesOra = int.Parse(v[4]);
            LandolasHelye = v[5];
            Legenyseg=int.Parse(v[6]);
            
        }

    }
}
