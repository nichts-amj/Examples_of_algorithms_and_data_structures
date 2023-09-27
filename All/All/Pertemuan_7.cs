using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    //Tree
    class Pertemuan_7
    {
        public void all_main()
        {
            Style Sty = new Style();
            Console.WriteLine(">>> Pertemuan ke 7 - Tree ");
            Console.WriteLine("1. Latihan 1 > Tree - All ");
            Console.WriteLine(">>>");
            Sty.titik(56);
            Console.WriteLine();
            tree the_tree = new tree();
            the_tree.insert(20);
            the_tree.insert(25);
            the_tree.insert(45);
            the_tree.insert(15);
            the_tree.insert(67);
            the_tree.insert(33);
        }
        
    }

    class Node
    {
        public int item;
        public Node leftc;
        public Node rigthc;
    }
    class tree
    {

        public Node root;
        public tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }

        public void insert(int id)
        {
            Node New_node = new Node();
            New_node.item = id;
            if (root == null)
            {
                root = New_node;
                Console.WriteLine(" --> " + root.item);

            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = New_node;
                            Console.WriteLine(" -L-> " + parent.leftc.item);
                            return;
                        }
                    }

                    else
                    {
                        current = current.rigthc;
                        if (current == null)
                        {
                            parent.rigthc = New_node;
                            Console.WriteLine(" -R-> " + parent.rigthc.item);
                            return;
                        }
                    }
                }
            }
        }



    }

}
