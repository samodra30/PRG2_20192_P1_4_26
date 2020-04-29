using System;

namespace PRG2_20192_P1_4_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int pilihan;
            Console.WriteLine("PROGRAM SEGITIGA SIKU-SIKU");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");

            Console.Write("\nMenu pilihan : ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            switch(pilihan)
            {
                case 1: HitungLuas(); break;
                case 2: HitungHipotenusa(); break;
                case 3: HitungKeliling(); break;
                case 4: Environment.Exit(-1); break;
                default:
                {
                        Console.WriteLine("Pilihan tidak tersedia!");
                        System.Console.ReadKey();
                        Main(null); 
                        break;
                }
            }

            Console.WriteLine("\n=====================================================================");
        }

        static void HitungLuas()
        {
            Console.WriteLine("\nLUAS SEGITIGA");
            Console.Write("Masukkan alas : ");
            double alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double tinggi = Convert.ToInt16(Console.ReadLine());

            double luas = 0.5 * alas * tinggi;

            Console.WriteLine("Luas segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah {2:0.00} satuan", alas, tinggi, luas);
        }

        static void HitungHipotenusa()
        {
            Console.Write("Masukkan alas : ");
            double alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double tinggi = Convert.ToInt16(Console.ReadLine());

            double hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));

            Console.WriteLine("Hipotenusa segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah {2:0.00} satuan", alas, tinggi, hipotenusa);
        }

        static void HitungKeliling()
        {
            Console.Write("Masukkan alas : ");
            double alas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double tinggi = Convert.ToInt16(Console.ReadLine());

            double hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));
            double keliling = alas + tinggi + hipotenusa;

            Console.WriteLine("Keliling segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah {2:0.00} satuan", alas, tinggi, keliling);
        }
    }
}
