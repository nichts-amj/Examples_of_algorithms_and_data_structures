using System;
using System.Collections.Generic;
using System.Collections;

namespace All
{
    class Program
    {
        static void Main(string[] args)
        {
            Style Sty = new Style();
            Pertemuan_2 P2 = new Pertemuan_2();
            Pertemuan_3 P3 = new Pertemuan_3();
            Pertemuan_4 P4 = new Pertemuan_4();
            Pertemuan_6 P6 = new Pertemuan_6();
            Pertemuan_7 P7 = new Pertemuan_7();
            Pertemuan_9 P9 = new Pertemuan_9();
            Pertemuan_10 P10 = new Pertemuan_10();
            Pertemuan_11 P11 = new Pertemuan_11();
            Pertemuan_12 P12 = new Pertemuan_12();

            Sty.titik(56);
            while (true)
            {
                //Console.WriteLine("<<<<....{MainMenu}....>>>>");
                Sty.titik(56);
                Console.WriteLine("{1}. ArrayList.........>>>");
                Console.WriteLine("{2}. Stack.............>>>");
                Console.WriteLine("{3}. Queue.............>>>");
                Console.WriteLine("{4}. LinkedList........>>>");
                Console.WriteLine("{5}. Tree..............>>>");
                Console.WriteLine("{6}. BubbleSort........>>>");
                Console.WriteLine("{7}. SelectionSort.....>>>");
                Console.WriteLine("{8}. InsertionSort.....>>>");
                Console.WriteLine("{9}. Graph.............>>>");
                Console.Write("....................>>> ");
                int jawab = int.Parse(Console.ReadLine());
                switch (jawab)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Sty.titik(56);
                        Console.WriteLine();
                        P2.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 2:
                        Sty.titik(56);
                        Console.WriteLine();
                        P3.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 3:
                        Sty.titik(56);
                        Console.WriteLine();
                        P4.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 4:
                        Sty.titik(56);
                        Console.WriteLine();
                        P6.latihan_1();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 5:
                        Sty.titik(56);
                        Console.WriteLine();
                        P7.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 6:
                        Sty.titik(56);
                        Console.WriteLine();
                        P9.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 7:
                        Sty.titik(56);
                        Console.WriteLine();
                        P10.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 8:
                        Sty.titik(56);
                        Console.WriteLine();
                        P11.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    case 9:
                        Sty.titik(56);
                        Console.WriteLine();
                        P12.all_main();
                        Sty.titik(56);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        return;
                }
            }
 
        }
    }
}
