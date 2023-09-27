using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_3
    { // Stack

        public void all_main()
        {
            Style Sty = new Style();
            while (true)
            {
                Console.WriteLine(">>> Pertemuan ke 3 - Stack");
                Console.WriteLine("1. Latihan 1 > Stack - While ");
                Console.WriteLine("2. Latihan 2 > Stack - Opsi ");
                Console.WriteLine("3. Latihan 3 > Stack - While - Merged");
                Console.Write(">>> ");
                int jawab = int.Parse(Console.ReadLine());
                switch (jawab)
                {
                    case 1:
                        Sty.titik(56);
                        Console.WriteLine();
                        Latihan();
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

        public void Latihan()
        {
            Stack card = new Stack();
            while (true)
            {
                Console.WriteLine("[1]. push");
                Console.WriteLine("[2]. pop");
                Console.WriteLine("[3]. peek");
                Console.WriteLine("[4]. tampilkan");
                Console.WriteLine("[5]. keluar");
                Console.Write("masukan pilihan : ");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("masukan kartu : ");
                        card.Push(Console.ReadLine());
                        break;
                    case 2:
                        if (card.Count > 0)
                        {
                            card.Pop();
                            Console.WriteLine("kartu palin atas berhasil diambil");
                        }
                        else
                        {
                            Console.WriteLine("operasi pop gagal, kartu tidak ada");
                        }
                        break;
                    case 3:
                        if (card.Count > 0)
                        {
                            card.Peek();
                            Console.WriteLine("kartu palin atas " + card.Peek());
                        }
                        else
                        {
                            Console.WriteLine("tidak ada kartu didalam stack");
                        }
                        break;
                    case 4:
                        foreach (String item in card)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        Console.WriteLine("terima kasih");
                        return;
                    default:
                        Console.WriteLine("pilihan tidak terdaftar");
                        break;
                }
                Console.ReadLine();

            }
        }

        public void Latihan2()
        {
            Stack card = new Stack();
            while (true)
            {
                Console.WriteLine("[1]. push");
                Console.WriteLine("[2]. pop");
                Console.WriteLine("[3]. peek");
                Console.WriteLine("[4]. tampilkan");
                Console.WriteLine("[5]. element");
                Console.WriteLine("[6]. hapus stack");
                Console.WriteLine("[7]. keluar");


                Console.Write("masukan pilihan : ");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.Write("masukan kartu : ");
                        card.Push(Console.ReadLine());
                        break;
                    case 2:
                        if (card.Count > 0)
                        {
                            card.Pop();
                            Console.WriteLine("kartu palin atas berhasil diambil");

                        }
                        else
                        {
                            Console.WriteLine("operasi pop gagal, kartu tidak ada");
                        }
                        break;
                    case 3:
                        if (card.Count > 0)
                        {
                            card.Peek();
                            Console.WriteLine("kartu palin atas " + card.Peek());

                        }
                        else
                        {
                            Console.WriteLine("tidak ada kartu didalam stack");
                        }
                        break;
                    case 4:
                        foreach (String item in card)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        Console.WriteLine("jumlah element stack adalah : " + card.Count);
                        break;
                    case 6:
                        card.Clear();
                        Console.WriteLine("data kartu stack telah dihapus");
                        break;
                    case 7:
                        Console.WriteLine("terima kasih");
                        return;
                    default:
                        Console.WriteLine("pilihan tidak terdaftar");
                        break;
                }
                Console.ReadLine();


            }

        }
        public void Latihan3()
        {
            Stack s1 = new Stack();
            Stack s2 = new Stack();
            Stack merged = new Stack();

            Console.Write("masukan banyak data dalam stack 1 : ");
            int data1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < data1; i++)
            {
                s1.Push(Console.ReadLine());
            }

            Console.Write("masukan banyak data dalam stack 2 : ");
            int data2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < data2; i++)
            {
                s2.Push(Console.ReadLine());
            }

            while (s2.Count > 0)
            {
                merged.Push(s2.Pop());
            }

            while (s1.Count > 0)
            {
                merged.Push(s1.Pop());
            }

            Console.WriteLine("Elemen paling atas Merged adalah : " + merged.Peek());

            foreach (String item in merged)
            {
                Console.WriteLine(item);
            }
        }
    }
}
