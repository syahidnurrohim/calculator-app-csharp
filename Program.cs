using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Pilihan Dibawah Ini : ");
            Console.WriteLine("Ketik 1 Untuk Penjumlahan");
            Console.WriteLine("Ketik 2 Untuk Pengurangan");
            Console.WriteLine("Ketik 3 Untuk Perkalian");
            Console.WriteLine("Ketik 4 Untuk Pembagian \n");
            Console.Write("Pilihan : ");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Nilai Pertama :");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Nilai Kedua :");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Pilihan Salah !! Ulangi");
                    break;
            }
            Console.WriteLine("Hasil Perhitungan : {0}", result);
            Console.ReadKey();
        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
    }
}