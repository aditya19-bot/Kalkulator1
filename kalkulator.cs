using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            float hasil;

            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih Menu Calculator :");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Input nomor menu [1..4] :");
            int pilihan = int.Parse(Console.In.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Inputkan nilai a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inputkan nilai b =");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (pilihan)
            {
                case 1:
                    hasil = a + b;
                    Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    Console.WriteLine("");
                    Console.WriteLine("\nTekan sembarang key untuk keluar");
                    Console.ReadKey();
                    break;
                case 2:
                    hasil = a - b;
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    Console.WriteLine("");
                    Console.WriteLine("\nTekan sembarang key untuk keluar");
                    Console.ReadKey();
                    break;
                case 3:
                    hasil = a * b;
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                    Console.WriteLine("");
                    Console.WriteLine("\nTekan sembarang key untuk keluar");
                    Console.ReadKey();
                    break;
                case 4:
                    hasil = a / b;
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                    Console.WriteLine("");
                    Console.WriteLine("\nTekan sembarang key untuk keluar");
                    Console.ReadKey();
                    break;

            }
        
        


        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}