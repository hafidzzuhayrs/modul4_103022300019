using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL_4
{
    internal class kodeProduk
    {
        public enum produkElektronik { Laptop, Smartphonr, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera};

        public static string GetkodeProduk(produkElektronik produkElektronik)
        {
            string[] KodeProduk = { "E100, E101, E102, E103, E104, E105, E106, E107, E108, E109 "};
            return KodeProduk[(int)produkElektronik];
        }
    }
}
