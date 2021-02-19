using System;
namespace OOPfundamental
{
     class program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Masukkan Merk Kendaraanmu?");
            string Merk = Console.ReadLine();
            Console.WriteLine("Masukkan Model Kendaraan?");
            string Model = Console.ReadLine();
            Console.WriteLine("Masukkan Horse Power Kendaraan Anda");
            double hp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Apakah kendaraan Anda menggunakan Turbo Charger? (0/1)");
            bool turbo = Convert.ToBoolean(Console.ReadLine());

            kendaraan Vehicle = new kendaraan(Merk, Model, hp, turbo);
            Vehicle.GetSpec();
            double Speed = Vehicle.GetVelocity(hp, turbo);
            Console.WriteLine("Kecepatan Optimal Mobil anda = {0} ", Speed);
        }
    }
}

