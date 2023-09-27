using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Pertemuan_12
    {
        public void all_main()
        {
            while (true)
            {
                Style Sty = new Style();
                Console.WriteLine(">>> Pertemuan ke 12 - Graph");
                Console.WriteLine("1. Latihan 1 > Undirected Graph");
                Console.WriteLine("2. Latihan 2 > Directed Graph");
                Console.Write(">>> ");
                int what_do = int.Parse(Console.ReadLine());
                switch (what_do)
                {
                    case 0:
                        Sty.titik(56);
                        BasicGraph graph = new BasicGraph(7);
                        graph.addEdge(2, 1);
                        graph.addEdge(3, 2);
                        graph.addEdge(4, 3);
                        graph.addEdge(4, 5);
                        graph.addEdge(5, 2);
                        graph.addEdge(5, 1);
                        graph.addEdge(6, 4);
                        graph.PrintAdjencyList();
                        break;
                    case 1:
                        Sty.titik(56);
                        BasicGraph1 graph1 = new BasicGraph1(7);
                        graph1.addEdge(2, 1);
                        graph1.addEdge(3, 2);
                        graph1.addEdge(4, 3);
                        graph1.addEdge(4, 5);
                        graph1.addEdge(5, 2);
                        graph1.addEdge(5, 1);
                        graph1.addEdge(6, 4);
                        graph1.PrintAdjencyMatrix();
                        break;
                    case 2:
                        Sty.titik(56);
                        BasicGraph2 graph2 = new BasicGraph2(7);
                        graph2.addEdge(2, 1);
                        graph2.addEdge(3, 2);
                        graph2.addEdge(4, 3);
                        graph2.addEdge(4, 5);
                        graph2.addEdge(5, 2);
                        graph2.addEdge(5, 1);
                        graph2.addEdge(6, 4);
                        graph2.PrintAdjencyList();
                        graph2.PrintAdjencyMatrix();
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
}
public class BasicGraph
{
    private int TotalSimpul;
    private LinkedList<int>[] LinkedListArray;
    public BasicGraph(int n)
    {
        TotalSimpul = n;
        LinkedListArray = new LinkedList<int>[n];
        for (int i = 0; i < n; i++)
        {
            LinkedListArray[i] = new LinkedList<int>();
        }
    }
    public void addEdge(int simpul, int adsimpul)
    {
        LinkedListArray[simpul].AddLast(adsimpul);
        LinkedListArray[adsimpul].AddLast(simpul);
    }

    public void PrintAdjencyList()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("Representasi Graph");
        Console.WriteLine("=================================================");
        Console.WriteLine("Representasi Graph menggunakan Adjency List");
        Console.WriteLine("-------------------------------------------------");
        string nodeString = "";
        for (int i = 0; i < LinkedListArray.Length; i++)
        {
            foreach (var item in LinkedListArray[i])
            {
                nodeString += " ->" + item;
            }
            nodeString += " ]\n";
        }
        Console.Write(nodeString);
    }
}
public class BasicGraph1
    {
        private int TotalSimpul;
        private LinkedList<int>[] LinkedListArray;
        private ArrayList matrik = new ArrayList();
        public BasicGraph1(int n)
        {
            TotalSimpul = n;
            LinkedListArray = new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
            {
                LinkedListArray[i] = new LinkedList<int>();
            }
        }
        public void addEdge(int simpul, int adsimpul)
        {
            LinkedListArray[simpul].AddLast(adsimpul);
            LinkedListArray[adsimpul].AddLast(simpul);

        }
        public void PrintAdjencyMatrix()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Representasi Directed Graph");
            Console.WriteLine("=================================================");
            Console.WriteLine("Representasi Graph menggunakan Adjency Matrix");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Simpul  ");
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                matrik.Add(0);
            }
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                Console.Write(i + " |  [  ");
                foreach (var item in LinkedListArray[i])
                {
                    matrik[item] = 1;
                }
                foreach (var item in matrik)
                {
                    Console.Write(item + "  ");
                }
                foreach (var item in LinkedListArray[i])
                {
                    matrik[item] = 0;
                }
                Console.WriteLine("]");
                Console.WriteLine();
            }
            Console.WriteLine("=================================================");
        }
    }
    public class BasicGraph2
    {
        private int TotalSimpul;
        private LinkedList<int>[] LinkedListArray;
        private ArrayList matrik = new ArrayList();
        public BasicGraph2(int n)
        {
            TotalSimpul = n;
            LinkedListArray = new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
            {
                LinkedListArray[i] = new LinkedList<int>();
            }
        }
        public void addEdge(int simpul, int adsimpul)
        {
            LinkedListArray[simpul].AddLast(adsimpul);
        }
        public void PrintAdjencyList()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Representasi Directed Graph");
            Console.WriteLine("=================================================");
            Console.WriteLine("Representasi Graph menggunakan Adjency List");
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                Console.Write($"[ Nilai simpul {i} dengan tetangga ");
                foreach (var item in LinkedListArray[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine(" ]");
                Console.WriteLine();
            }
        }
        public void PrintAdjencyMatrix()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("Representasi Graph menggunakan Adjency Matrix");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Simpul  ");
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                matrik.Add(0);
            }
            for (int i = 0; i < LinkedListArray.Length; i++)
            {
                Console.Write(i + " |  [  ");
                foreach (var item in LinkedListArray[i])
                {
                    matrik[item] = 1;
                }
                foreach (var item in matrik)
                {
                    Console.Write(item + "  ");
                }
                foreach (var item in LinkedListArray[i])
                {
                    matrik[item] = 0;
                }
                Console.WriteLine("]");
                Console.WriteLine();
            }
            Console.WriteLine("=================================================");
        }
    }

