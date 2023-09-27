using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_4
    {
        //Queue
        public void all_main()
        {
            Style Sty = new Style();
            while (true)
            {
                Console.WriteLine(">>> Pertemuan ke 4 - Queue");
                Console.WriteLine("1. Latihan 1 > Queue - While ");
                Console.WriteLine("2. Latihan 2 > Queue - Opsi");
                Console.WriteLine("3. Latihan 3 > Queue - Binery ");
                Console.Write(">>> ");
                int jawab = int.Parse(Console.ReadLine());
                switch (jawab)
                {
                    case 1:
                        Sty.titik(56);
                        Console.WriteLine();
                        Latihan1();
                        break;
                    case 2:
                        Sty.titik(56);
                        Console.WriteLine();
                        Latihan2();
                        break;
                    case 3:
                        Sty.titik(56);
                        Console.WriteLine();
                        Latihan3();
                        break;
                    default:
                        Console.WriteLine("Return");
                        return;
                }
                Console.ReadKey();
                Sty.titik(56);
                Console.WriteLine();
            }
            
      
        }
        public void Latihan1()
        {
            Queue Pelanggan = new Queue();
            while (true)
            {
                Console.WriteLine("[1]. Enqueue");
                Console.WriteLine("[2]. Dequeue");
                Console.WriteLine("[3]. peek");
                Console.WriteLine("[4]. tampilakan");
                Console.WriteLine("[5]. keluar");
                Console.Write("Masukan pilihan : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Masukan Nama Pelanggan : ");
                        Pelanggan.Enqueue(Console.ReadLine());
                        break;
                    case 2:
                        if (Pelanggan.Count > 0)
                        {
                            Pelanggan.Dequeue();
                            Console.WriteLine("Data Pelanggan Pertama Berhasil Dihapus");
                        }
                        else
                        {
                            Console.WriteLine("Operasi Gagal Data Pelanggan Tidak Ada");
                        }
                        break;
                    case 3:
                        if (Pelanggan.Count > 0)
                        {
                            Console.WriteLine("Data Pelanggan Paling Awal : " + Pelanggan.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Pelanggan Tidak Ada");
                        }
                        break;
                    case 4:
                        foreach (string item in Pelanggan)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        Console.WriteLine("terima kasih");
                        return;
                    default:
                        Console.WriteLine("Pilihan Tidak Terdaftar");
                        break;
                }              
                Console.ReadLine();
                
            }
        }

        public void Latihan2()
        {
            Queue Pelanggan = new Queue();
            while (true)
            {
                Console.WriteLine("[1]. Enqueue");
                Console.WriteLine("[2]. Dequeue");
                Console.WriteLine("[3]. peek");
                Console.WriteLine("[4]. Tampilakan");
                Console.WriteLine("[5]. Jumlah Data Pelanggan");
                Console.WriteLine("[6]. Hapus data");
                Console.WriteLine("[7]. keluar");
                Console.Write("Masukan pilihan : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Masukan Nama Pelanggan : ");
                        Pelanggan.Enqueue(Console.ReadLine());
                        break;
                    case 2:
                        if (Pelanggan.Count > 0)
                        {
                            Pelanggan.Dequeue();
                            Console.WriteLine("Data Pelanggan Pertama Berhasil Dihapus");
                        }
                        else
                        {
                            Console.WriteLine("Operasi Gagal Data Pelanggan Tidak Ada");
                        }
                        break;
                    case 3:
                        if (Pelanggan.Count > 0)
                        {
                            Console.WriteLine("Data Pelanggan Paling Awal : " + Pelanggan.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Pelanggan Tidak Ada");
                        }
                        break;
                    case 4:
                        foreach (string item in Pelanggan)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Jumlah Data Pelanggan Adalah : " + Pelanggan.Count);
                        break;
                    case 6:
                        Pelanggan.Clear();
                        Console.WriteLine("Data pelanggan Berhasil Di Hapus");
                        break;
                    case 7:
                        Console.WriteLine("terima kasih");
                        return;
                    default:
                        Console.WriteLine("Pilihan Tidak Terdaftar");
                        break;
                }             
                Console.ReadLine();
               
            }
        }

        public void Latihan3()
        {
            Queue Binary = new Queue();
            Stack balik = new Stack();

            Console.Write("Masukan Batas Akhir Angka binary : ");
            int batas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= batas; i++)
            {
                Binary.Enqueue(i);
            }

            while (batas > 0)
            {
                int temp = Convert.ToInt32(Binary.Peek());

                while (temp > 0)
                {
                    int bagi = temp % 2;

                    temp /= 2;

                    balik.Push(bagi);
                }

                foreach (var item in balik)
                {
                    Console.Write(item);
                }

                balik.Clear();

                Console.WriteLine();

                Binary.Dequeue();
                batas--;
            }
        }
       
    }
}
