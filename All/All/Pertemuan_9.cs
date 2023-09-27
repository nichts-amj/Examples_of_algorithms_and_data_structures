using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_9
    {
        public void all_main()
        {
            Style Sty = new Style();
            while (true)
            {
                Console.WriteLine(">>> Pertemuan ke 9 - Bubble Sort");
                Console.WriteLine("1. Latihan 1 > Bubble Sort ");
                Console.WriteLine("2. Latihan 2 > Bubble Sort - Console.ReadLine()");
                Console.Write(">>> ");
                int what_do = int.Parse(Console.ReadLine());

                switch (what_do)
                {
                    case 1:
                        Sty.titik(56);
                        Console.WriteLine();
                        NilaiMahasiswa_0 nilai_kelas_01 = new NilaiMahasiswa_0(5);
                        nilai_kelas_01.Insert(29);
                        nilai_kelas_01.Insert(11);
                        nilai_kelas_01.Insert(14);
                        nilai_kelas_01.Insert(23);
                        nilai_kelas_01.Insert(17);
                        Console.WriteLine("Elemen sebelum disorting : ");
                        nilai_kelas_01.TampilElemen();
                        Console.WriteLine();

                        nilai_kelas_01.BubbleSort();

                        Console.WriteLine("Elemen setelah disorting : ");
                        nilai_kelas_01.TampilElemen();
                        Console.ReadLine();
                        break;

                    case 2:
                        Sty.titik(56);
                        Console.WriteLine();
                        Console.Write("Masukan Total Nilai : ");
                        NilaiMahasiswa_1 nilai_kelas_02 = new NilaiMahasiswa_1(int.Parse(Console.ReadLine()));

                        nilai_kelas_02.Insert();
                        Console.WriteLine();

                        Console.WriteLine("Elemen sebelum disorting : ");
                        nilai_kelas_02.TampilElemen();
                        Console.WriteLine();

                        nilai_kelas_02.BubbleSort();

                        Console.WriteLine("Elemen setelah disorting : ");
                        nilai_kelas_02.TampilElemen();
                        Console.ReadLine();
                        break;

                    default:

                        Console.WriteLine("Return");
                        return;
                }
                Sty.titik(56);
                Console.WriteLine();
            }
            
            
        }

    }

    //Latihan 1
    class NilaiMahasiswa_0
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public NilaiMahasiswa_0(int Kapasitas)
        {
            arr = new int[Kapasitas];
            atas = Kapasitas - 1;
            jmlElemen = 0;
        }
        public void Insert(int item)
        {
            arr[jmlElemen] = item;
            jmlElemen++;
        }
        public void TampilElemen()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
                Console.WriteLine();
            }
        }
        public void BubbleSort()
        {
            int temp;
            Console.WriteLine("Proses bubble sort");
            for (int luar = atas; luar >= 1; luar--)
            {
                Console.WriteLine("------------------");
                for (int dalam = 0; dalam <= luar - 1; dalam++)
                {
                    if (arr[dalam] < arr[dalam + 1])
                    {
                        temp = arr[dalam];
                        arr[dalam] = arr[dalam + 1];
                        arr[dalam + 1] = temp;
                    }
                    TampilElemen();
                }
                Console.WriteLine("------------------");
            }
            Console.WriteLine();
        }
    }

    class NilaiMahasiswa_1
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        private int nilai;
        public NilaiMahasiswa_1(int Kapasitas)
        {
            arr = new int[Kapasitas];
            nilai = Kapasitas;
            atas = Kapasitas - 1;
            jmlElemen = 0;
        }
        public void Insert()
        {
            for (int i = 1; i <= nilai; i++)
            {
                Console.Write($"Masukan Nilai Ke-{i}  : ");
                arr[jmlElemen] = int.Parse(Console.ReadLine());
                jmlElemen++;
            }
        }
        public void TampilElemen()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
                Console.WriteLine();
            }
        }
        public void BubbleSort()
        {
            int temp;
            Console.WriteLine("Proses bubble sort");
            for (int luar = atas; luar >= 1; luar--)
            {
                Console.WriteLine("------------------");
                for (int dalam = 0; dalam <= luar - 1; dalam++)
                {
                    if (arr[dalam] > arr[dalam + 1])
                    {
                        temp = arr[dalam];
                        arr[dalam] = arr[dalam + 1];
                        arr[dalam + 1] = temp;
                    }
                    TampilElemen();
                }
                Console.WriteLine("------------------");
            }
            Console.WriteLine();
        }
    }
}
