using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_10
    {
        public void all_main()
        {
            Style Sty = new Style();
            while (true)
            {
                Console.WriteLine(">>> Pertemuan ke 10 - Selection Sort");
                //Console.WriteLine("1. Contoh 0 > Selection Sort");
                Console.WriteLine("1. Latihan 1 > Selection Sort - Swap ");
                Console.WriteLine("2. Latihan 2 > Selection Sort - Choise");
                Console.Write(">>> ");
                int what_do = int.Parse(Console.ReadLine());
                switch (what_do)
                {
                    case 0:
                        Sty.titik(56);
                        Console.WriteLine();
                        Console.Write("Masukan total nilai : ");
                        int total_element = int.Parse(Console.ReadLine());
                        NilaiMahasiswa0 nilai_kelas = new NilaiMahasiswa0(total_element);
                        for (int i = 1; i <= total_element; i++)
                        {
                            Console.Write($"Masukan elemen ke {i} : ");
                            nilai_kelas.insert(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine("Elemen sebelum disortir : ");
                        nilai_kelas.tampilElemen();
                        Console.WriteLine();

                        nilai_kelas.SelectionSort();

                        nilai_kelas.tampilElemen();
                        Console.WriteLine();
                        break;
                    case 1:
                        Sty.titik(56);
                        Console.WriteLine();
                        Console.Write(">>> Input Total Values : ");
                        int total_element1 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        NilaiMahasiswa1 nilai_kelas1 = new NilaiMahasiswa1(total_element1);
                        for (int i = 0; i < total_element1; i++)
                        {
                            Console.Write($">>> Input Elemen Index [{i}] : ");
                            nilai_kelas1.insert(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine();
                        Console.Write(">>> Elements Before Sorting : ");
                        nilai_kelas1.tampilElemen();
                        Console.WriteLine();
                        string perulangan;
                        do
                        {
                            Console.Write(">>> Swap Elemen Index [x] : ");
                            int index1 = int.Parse(Console.ReadLine());
                            Console.Write(">>> With Elemen Index [y] : ");
                            int index2 = int.Parse(Console.ReadLine());
                            if (index1 < total_element1 && index2 < total_element1)
                            {
                                nilai_kelas1.Swap(index1, index2);
                                Console.WriteLine();
                                Console.Write(">>> Elements After Sorting  : ");
                                nilai_kelas1.tampilElemen();
                                Console.WriteLine();
                                Console.Write(">>> Swap Again (Y/N) ? ");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine(">>> Index Out Of Range !");
                                Console.WriteLine();
                                Console.Write(">>> Try Again (Y/N) ? ");
                            }
                            perulangan = Console.ReadLine();
                            Console.WriteLine();
                        } while (perulangan == "Y" || perulangan == "y");
                        Console.WriteLine(">>> Exit");
                        Console.ReadKey();
                        break;

                    case 2:
                        Sty.titik(56);
                        Console.WriteLine();
                        Console.Write(">>> Masukan total nilai : ");
                        int total_element2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        NilaiMahasiswa2 nilai_kelas2 = new NilaiMahasiswa2(total_element2);
                        for (int i = 1; i <= total_element2; i++)
                        {
                            Console.Write($">>> Masukan Elemen Index ke [{i}] : ");
                            nilai_kelas2.insert(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine();
                        Console.Write(">>> Elemen Sebelum Disortir : ");
                        nilai_kelas2.tampilElemen();
                        Console.WriteLine();
                        while (true)
                        {
                            Console.WriteLine(">>> [1]. Sorting untuk urutan menaik (ascending)");
                            Console.WriteLine(">>> [2]. Sorting untuk urutan menurun (descending)");
                            Console.WriteLine(">>> [3]. Keluar");
                            Console.Write(">>>  ");
                            int pilih = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            switch (pilih)
                            {
                                case 1:
                                    nilai_kelas2.SelectionSort1();
                                    Console.Write(">>> Elemen Setelah Disortir : ");
                                    nilai_kelas2.tampilElemen();
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    nilai_kelas2.SelectionSort2();
                                    Console.Write(">>> Elemen Setelah Disortir : ");
                                    nilai_kelas2.tampilElemen();
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    Console.WriteLine(">>> Exit");
                                    return;
                                default:
                                    Console.WriteLine(">>> Pilihan Tidak Tersedia");
                                    Console.WriteLine();
                                    break;
                            }
                        }                       
                    default:
                        Console.WriteLine("Return");
                        return;
                }
                Sty.titik(56);
                Console.WriteLine();
            }
        }

    }
    public class NilaiMahasiswa0
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public NilaiMahasiswa0(int kapasitas)
        {
            arr = new int[kapasitas];
            atas = kapasitas - 1;
            jmlElemen = 0;
        }
        public void insert(int item)
        {
            arr[jmlElemen] = item;
            jmlElemen++;
        }
        public void tampilElemen()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void SelectionSort()
        {
            int temp, min;
            Console.WriteLine("Proses se;ection sort");
            for (int luar = 0; luar <= atas; luar++)
            {
                min = luar;
                Console.WriteLine("---------------");
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

                tampilElemen();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    public class NilaiMahasiswa1
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public NilaiMahasiswa1(int kapasitas)
        {
            arr = new int[kapasitas];
            atas = kapasitas - 1;
            jmlElemen = 0;
        }
        public void insert(int item)
        {
            arr[jmlElemen] = item;
            jmlElemen++;
        }
        public void tampilElemen()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Swap(int first, int last)
        {
            if (arr[first] > arr[last])
            {
                int temp = arr[last];
                arr[last] = arr[first];
                arr[first] = temp;
            }
            else
            {
                int temp = arr[last];
                arr[last] = arr[first];
                arr[first] = temp;
            }
        }
    }

    public class NilaiMahasiswa2
    {
        private int[] arr;
        private int atas;
        private int jmlElemen;
        public NilaiMahasiswa2(int kapasitas)
        {
            arr = new int[kapasitas];
            atas = kapasitas - 1;
            jmlElemen = 0;
        }
        public void insert(int item)
        {
            arr[jmlElemen] = item;
            jmlElemen++;
        }
        public void tampilElemen()
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void SelectionSort1()
        {
            int temp, min;
            Console.WriteLine(">>> Proses selection sort");
            for (int luar = 0; luar <= atas; luar++)
            {
                min = luar;
                Console.WriteLine("---------------");
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

                tampilElemen();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }

        }
        public void SelectionSort2()
        {
            int temp, min;
            Console.WriteLine(">>> Proses selection sort");
            for (int luar = 0; luar <= atas; luar++)
            {
                min = luar;
                Console.WriteLine("---------------");
                for (int dalam = luar + 1; dalam <= atas; dalam++)
                {
                    if (arr[dalam] >= arr[min])
                    {
                        min = dalam;
                    }
                }
                temp = arr[luar];
                arr[luar] = arr[min];
                arr[min] = temp;

                tampilElemen();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }
        }
    }
}
