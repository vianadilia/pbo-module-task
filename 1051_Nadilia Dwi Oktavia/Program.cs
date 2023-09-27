using System;

namespace KomponenKomputer
{
    public class Vga
    {
        public string Merk;

        public Vga(string merk)
        {
            Merk = merk;
        }
    }

    public class Processor
    {
        public string Merk;
        public string Tipe;

        public Processor(string merk, string tipe)
        {
            Merk = merk;
            Tipe = tipe;
        }
    }

    public class Laptop
    {
        public string Merk;
        public string Tipe;
        public Vga Vga;
        public Processor Processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            Merk = merk;
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }
    }

    public class Predator : Laptop
    {
        public Predator(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor) { }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
        }
    }

    public class Vivobook : Laptop
    {
        public Vivobook(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor) { }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class Ideapad : Laptop
    {
        public Ideapad(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variabel
            Laptop laptop1 = new Vivobook("Vivobook", new Vga("Nvidia"), new Processor("Intel", "Core i5"));
            Laptop laptop2 = new Ideapad("IdeaPad", new Vga("AMD"), new Processor("AMD", "Ryzen"));
            Predator predator = new Predator("Predator", new Vga("AMD"), new Processor("Intel", "Core i7"));

            // Laptop1
            Console.WriteLine("laptop1");
            Console.WriteLine($"Merk Vga: {laptop1.Vga.Merk}");
            Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
            Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");
            Console.WriteLine();

            // Laptop2
            Console.WriteLine("laptop2");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine();

            // Predator
            predator.BermainGame();

            //laptop1.Ngoding();

            //ACER acer = predator; // Menggunakan objek predator sebagai nilai acer
            //acer.BermainGame();
        }
    }
}