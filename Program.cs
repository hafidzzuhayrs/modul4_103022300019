
using System;
using static MODUL_4.FanLaptop;
using MODUL_4;

namespace MODUL_4

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Produk Elektronik");
            Console.WriteLine("===================================");
            Console.WriteLine("Produk Elektronik \t |    Kode Produk");
            Console.WriteLine("===================================");
            foreach (kodeProduk.produkElektronik kel in Enum.GetValues(typeof(kodeProduk.produkElektronik)))
            {
                String namaProduk = kel.ToString();
                Console.WriteLine($"{kel,-16} |     {kodeProduk.GetkodeProduk(kel)}");
            }

            Console.WriteLine("\n===================================");
            FanLaptop door = new FanLaptop();

            door.getFanLaptop();
            String input = "";
            while (input != "exit")
            {
                Console.WriteLine("Masukkan Perintah (bukaPintu/kunciPintu)");
                input = Console.ReadLine();
                if (Enum.TryParse(input, result: out kegiatan trigger))
                {
                    door.UbahStateFan(trigger);
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid. Coba lagi.");
                }
                Console.WriteLine("===================================");
            }
        }
    }




}