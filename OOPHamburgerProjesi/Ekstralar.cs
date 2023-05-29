using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerProjesi
{
    public class Ekstra
    {
        public string EkstraAdi { get; set; }
        public double Fiyat { get; set; }
        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra {EkstraAdi= "Ketçap",Fiyat = 0.75},
            new Ekstra {EkstraAdi = "Mayonez", Fiyat = 0.75},
            new Ekstra {EkstraAdi = "Hardal", Fiyat = 0.99},
            new Ekstra {EkstraAdi = "Ranch", Fiyat = 0.99},
            new Ekstra {EkstraAdi = "BBQ", Fiyat = 0.99},
            new Ekstra {EkstraAdi = "Buffalo", Fiyat = 0.99}
        };
    }
}
