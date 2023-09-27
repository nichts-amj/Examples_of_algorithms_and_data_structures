using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_6
    {
        //LinkedList     
       public void latihan_1()
        {
            Style Sty = new Style();
            Sty.titik(56);
            Console.WriteLine();

            Console.WriteLine(">>> Pertemuan ke 6 - LinkedList");
            Console.WriteLine("1. Latihan 1 > LinkedList - Opsi");
            Console.WriteLine(">>>");

            LinkedList<string> nama = new LinkedList<string>();
            while (true)
            {
                Console.WriteLine("[1]. Menambahkan 1 nama di akhir");
                Console.WriteLine("[2]. Menambahkan 1 nama di awal");
                Console.WriteLine("[3]. Menambahkan 1 nama setelah input nama");
                Console.WriteLine("[4]. Menambahkan 1 nama sebelum input nama");
                Console.WriteLine("[5]. Menghapus 1 nama di awal");
                Console.WriteLine("[6]. Menghapus 1 nama di akhir");
                Console.WriteLine("[7]. Menghapus 1 nama dari input_nama");
                Console.WriteLine("[8]. Keluar");
                Console.Write(" * Masukan pilihan : ");
                int pilih = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (pilih)
                {
                    case 1:
                        Console.Write("Masukan Nama : ");
                        nama.AddLast(Console.ReadLine());
                        Console.WriteLine("Menambahkan nama " + nama.Last.Value + " di akhir");
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}]");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Masukan Nama : ");
                        nama.AddFirst(Console.ReadLine());
                        Console.WriteLine("Menambahkan nama " + nama.First.Value + " di awal");
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Masukan Nama Yang Ingin Ditambahkan : ");
                        nama.AddFirst(Console.ReadLine());
                        Console.Write("Masukan Nama Yang Ingin Disisipkan Setelahnya : ");
                        LinkedListNode<string> node = nama.Find(nama.First.Value);
                        nama.AddAfter(node, Console.ReadLine());
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Masukan Nama Yang Ingin Ditambahkan : ");
                        nama.AddFirst(Console.ReadLine());
                        Console.Write("Masukan Nama Yang Ingin Disisipkan Sebelum : ");
                        LinkedListNode<string> node1 = nama.Find(nama.First.Value);
                        nama.AddBefore(node1, Console.ReadLine());
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        nama.RemoveFirst();
                        Console.WriteLine("Menghapus Nama Pertama -> ");
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        nama.RemoveLast();
                        Console.WriteLine("Menghapus Nama terakhir -> ");
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.Write("Masukan Nama Yang Ingin Di Hapus : ");
                        LinkedListNode<string> node2 = nama.Find(Console.ReadLine());
                        Console.WriteLine("Menghapus Nama -> ");
                        nama.Remove(node2);
                        foreach (string item in nama)
                        {
                            Console.Write($"[{item}] -> ");
                        }
                        break;
                    case 8:
                        Console.WriteLine(" * Terima kasih");                      
                        return;
                    default:
                        Console.WriteLine("Pilihan Tidak Tersedia");
                        break;
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}
