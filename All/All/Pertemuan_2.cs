using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_2
    {
        //ArrayList
        public void all_main()
        {
            Style Sty = new Style();
            while (true)
            {
                Console.WriteLine(">>> Pertemuan ke 2 - ArrayList");
                Console.WriteLine("1. Latihan 1 > ArrayList - foreach ");
                Console.WriteLine("2. Latihan 2 > ArrayList - descending - foreach ");
                Console.WriteLine("3. Latihan 3 > ArrayList - Console.ReadLine() - Reverse ");
                Console.Write(">>> ");
                int jawab = int.Parse(Console.ReadLine());

                switch (jawab)
                {
                    case 1:
                        latihan_1();
                        break;
                    case 2:
                        latihan_2();
                        break;
                    case 3:
                        latihan_3();
                        break;
                    default:
                        Console.WriteLine("Return");
                        return;
                }
                Console.ReadKey();
                Console.WriteLine();
                Sty.titik(56);
                Console.WriteLine();
            }
      
        }

        public void latihan_1()
        {
            bintang(50);
            Console.WriteLine(">>> LATIHAN 1");
            garis(50);
            Console.Write("masukan jumlah data  : ");
            int total_data = int.Parse(Console.ReadLine());
            garis(50);
            ArrayList Nama = new ArrayList();
            ArrayList Nim = new ArrayList();
            ArrayList Jurusan = new ArrayList();

            for (int i = 0; i < total_data; i++)
            {
                Console.Write($"Masukan nama ke {i}    : ");
                Nama.Add(Console.ReadLine());

                Console.Write($"Masukan Nim ke {i}     : ");
                Nim.Add(Console.ReadLine());

                Console.Write($"Masukan Jurusan ke {i} : ");
                Jurusan.Add(Console.ReadLine());

                garis(50);

            }

            foreach (object i in Nama)
            {
                Console.WriteLine($"Nama       : {i}");
            }
            foreach (object i in Nim)
            {
                Console.WriteLine($"Nim        : {i}");
            }
            foreach (object i in Jurusan)
            {
                Console.WriteLine($"jurusan    : {i}");
            }

            bintang(50);

        }

        public void latihan_2()
        {
            Console.WriteLine(">>> LATIHAN 2");
            garis(50);

            ArrayList data = new ArrayList();
            for (int i = 10; i > 0; i--)
            {
                data.Add(i);
            }

            foreach (var item in data)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            bintang(50);
        }

        public void latihan_3()
        {
            Console.WriteLine(">>> LATIHAN 3");
            garis(50);

            Console.Write("Masukan jumlah data : ");
            int Jumlah_data = int.Parse(Console.ReadLine());
            garis(50);

            ArrayList data1 = new ArrayList();

            for (int i = 0; i < Jumlah_data; i++)
            {
                Console.Write($"masukan data ke {i} : ");
                data1.Add(Console.ReadLine());

            }

            garis(50);

            data1.Reverse();
            foreach (object i in data1)
            {
                Console.WriteLine($"Data : {i}");

            }

            bintang(50);
            Console.ReadKey();
        }

        public void garis(int garis1)
        {
            for (int i = 0; i < garis1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public void bintang(int bintang1)
        {
            for (int i = 0; i < bintang1; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
