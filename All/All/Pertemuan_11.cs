using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_11
    {
        public void all_main()
        {
            while (true)
            {
                Style Sty = new Style();
                Console.WriteLine(">>> Pertemuan ke 11 - Insertion Sort");
                Console.WriteLine("1. Latihan 1 > Insertion Sort");
                Console.WriteLine("2. Latihan 2 > Insertion Sor - Choise 10 - 9");
                Console.Write(">>> ");
                int what_do = int.Parse(Console.ReadLine());
                switch (what_do)
                {
                    case 1:
                        Sty.titik(56);
                        Console.Write("Masukan Total Nilai : ");
                        int total_element1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Insertion_Sort1 nilai_kelas = new Insertion_Sort1(total_element1);
                        for (int i = 1; i <= total_element1; i++)
                        {
                            Console.Write($"Input Elemen Index [{i}] : ");
                            nilai_kelas.Insert(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine();

                        Console.WriteLine("Elemen Sebelum Sorting : ");
                        nilai_kelas.TampilElemen();
                        Console.WriteLine();

                        nilai_kelas.InsertionSort();
                        Console.WriteLine();

                        Console.WriteLine("Elemen Setelah Sorting : ");
                        nilai_kelas.TampilElemen();
                        Console.ReadKey();
                        break;
                    case 2:
                        Sty.titik(56);
                        String ulang;
                        do
                        {
                            Console.Write("Masukan Total Nilai : ");
                            int total_element2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Insertion_Sort2 nilai_kelas2 = new Insertion_Sort2(total_element2);
                            for (int i = 1; i <= total_element2; i++)
                            {
                                Console.Write($"Input Elemen Index [{i}] : ");
                                nilai_kelas2.Insert(int.Parse(Console.ReadLine()));
                            }
                            Console.WriteLine();

                            Console.WriteLine("[1]. Bubble Sort ");
                            Console.WriteLine("[2]. Selection Sort");
                            Console.WriteLine("[3]. Insertion Sort");
                            Console.WriteLine("[4]. keluar");
                            Console.Write("Jawaban :  ");
                            int jawaban = int.Parse(Console.ReadLine());

                            Console.WriteLine();

                            switch (jawaban)
                            {
                                case 1:
                                    Console.WriteLine("Elemen Sebelum Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    nilai_kelas2.BubbleSort();
                                    Console.WriteLine();
                                    Console.WriteLine("Elemen Setelah Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Elemen Sebelum Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    nilai_kelas2.SelectionSort();
                                    Console.WriteLine();
                                    Console.WriteLine("Elemen Setelah Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Elemen Sebelum Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    nilai_kelas2.InsertionSort();
                                    Console.WriteLine();
                                    Console.WriteLine("Elemen Setelah Sorting : ");
                                    nilai_kelas2.TampilElemen();
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Exit, bye !");
                                    return;
                                default:
                                    Console.WriteLine("Pilihan tidak tersedia !");
                                    Console.WriteLine();
                                    break;
                            }
                            Console.ReadKey();
                            Console.Write("Sorting Lagi (Y/N) ? ");
                            ulang = Console.ReadLine();
                            Console.WriteLine();
                        } while (ulang == "y" || ulang == "Y");
                        Console.WriteLine("Exit, bye !");
                        break;
                    default:
                        Console.WriteLine("Exit");
                        return;
                }
                Sty.titik(56);
                Console.WriteLine();
            }
        }

    }
    public class Insertion_Sort1
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public Insertion_Sort1(int Kapasitas)
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
            }
            Console.WriteLine();
        }
        public void InsertionSort()
        {
            Console.WriteLine("Proses Insertion Sort : ");
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                garis(atas * 2 + 3);
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                TampilElemen();
                garis(atas * 2 + 3);
            }
        }
        public void garis(int garis)
        {
            for (int i = 0; i < garis; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }

    public class Insertion_Sort2
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public Insertion_Sort2(int Kapasitas)
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
            }
            Console.WriteLine();
        }
        public void BubbleSort()
        {
            int temp;
            Console.WriteLine("Proses Bubble Sort : ");
            for (int luar = atas; luar >= 1; luar--)
            {
                garis(atas * 2 + 3);
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
                garis(atas * 2 + 3);
            }
        }
        public void SelectionSort()
        {
            int temp, min;
            Console.WriteLine("Proses Selection Sort : ");
            for (int luar = 0; luar <= atas; luar++)
            {
                min = luar;
                garis(atas * 2 + 3);
                for (int dalam = luar + 1; dalam <= atas; dalam++)
                {
                    if (arr[dalam] < arr[min])
                    {
                        min = dalam;
                    }
                }
                temp = arr[luar];
                arr[luar] = arr[min];
                arr[min] = temp;

                TampilElemen();
                garis(atas * 2 + 3);
            }
        }
        public void InsertionSort()
        {
            Console.WriteLine("Proses Insertion Sort : ");
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                garis(atas * 2 + 3);
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                TampilElemen();
                garis(atas * 2 + 3);
            }
        }
        public void garis(int garis)
        {
            for (int i = 0; i < garis; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
