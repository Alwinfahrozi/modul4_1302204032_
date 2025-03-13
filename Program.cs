
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace modul4_1302204032_
{

    class KodeProduk
    {
        public enum Produk { Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera };

        // Table-driven technique implementation
        private static Dictionary<Produk, string> TabelKodeProduk = new Dictionary<Produk, string>()
        {

            { Produk.Laptop, "E100" },
            { Produk.Smartphone, "E101" },
            { Produk.Tablet, "E102" },
            { Produk.Headset, "E103" },
            { Produk.Keyboard, "E104" },
            { Produk.Mouse, "E105" },
            { Produk.Printer, "E106" },
            { Produk.Monitor, "E107" },
            { Produk.Smartwatch, "E108" },
            { Produk.Kamera, "E109" },
        };

        // Method to get postal code using table-driven approach
        public static int getKodeProduk(Produk produk)
        {
            return int.Parse(TabelKodeProduk[produk]);
        }

        // New method that returns postal code from given label
        public static string getKodeProduk(string produkLabel)
        {
            // Convert the label to enum and return the corresponding postal code
            if (Enum.TryParse(produkLabel, out Produk pro))
            {
                return TabelKodeProduk[pro];
            }
            return "Kode produk tidak ditemukan";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display kelurahan list with postal codes
            Console.WriteLine("Produk Elektronik");
            Console.WriteLine("===================================");
            Console.WriteLine("Kode Produk ");
            Console.WriteLine("===================================");

            // Display table using the new method
            Console.WriteLine($"{"Laptop",-16} |     {KodeProduk.getKodeProduk("Laptop")}");
            Console.WriteLine($"{"Smarthphone",-16} |     {KodeProduk.getKodeProduk("Smarthphone")}");
            Console.WriteLine($"{"Tablet",-16} |     {KodeProduk.getKodeProduk("Tablet")}");
            Console.WriteLine($"{"Headset",-16} |     {KodeProduk.getKodeProduk("Headset")}");
            Console.WriteLine($"{"Keyboard",-16} |     {KodeProduk.getKodeProduk("Keyboard")}");
            Console.WriteLine($"{"Mouse",-16} |     {KodeProduk.getKodeProduk("Mouse")}");
            Console.WriteLine($"{"Printer",-16} |     {KodeProduk.getKodeProduk("Printer")}");
            Console.WriteLine($"{"Monitor",-16} |     {KodeProduk.getKodeProduk("Monitor")}");
            Console.WriteLine($"{"Smartwatch",-16} |     {KodeProduk.getKodeProduk("Smartwatch")}");
            Console.WriteLine($"{"Kamera",-16} |     {KodeProduk.getKodeProduk("Kamera")}");
            

            Console.WriteLine("\n===================================");

            // Door Machine state simulation
            DoorMachine door = new DoorMachine();
            door.getStatusPintu();

            String input = "";
            while (input != "exit")
            {
                Console.WriteLine("Masukkan Perintah (bukaPintu/kunciPintu)");
                input = Console.ReadLine();

                if (Enum.TryParse(input, out kegiatan trigger))
                {
                    door.ubahStatePintu(trigger);
                }
                else if (input != "exit")
                {
                    Console.WriteLine("Perintah tidak valid. Coba lagi.");
                }

                Console.WriteLine("===================================");
            }
        }
    }
}