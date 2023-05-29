using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerProjesi
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public double MenuFiyati { get; set; }
        public static List<Menu> MenuList = new List<Menu>()
        {
            new Menu{MenuAdi = "SteakHouse Burger Menü" ,MenuFiyati = 139.99},
            new Menu{MenuAdi = "Double KöfteBurger Menü",MenuFiyati= 104.99},
            new Menu{MenuAdi = "Etli Barbekü Brioche Menü", MenuFiyati=159.99},
            new Menu{MenuAdi = "Plant Based Whooper Menü", MenuFiyati=129.99},
            new Menu{MenuAdi = "Rodeo Whooper Menü", MenuFiyati=149.99},
            new Menu{MenuAdi = "Tavuklu Barbekü Brioche Menü", MenuFiyati=129.99},
            new Menu{MenuAdi = "Truflu King Beef Burger Menü", MenuFiyati=154.99},
            new Menu{MenuAdi = "Tripple Whooper Menü", MenuFiyati=204.99}
        };
    }
}
