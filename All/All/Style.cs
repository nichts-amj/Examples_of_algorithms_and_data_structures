using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Style
    {
        public void garis(int garis1)
        {
            for (int i = 0; i < garis1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        public void sama(int bintang1)
        {
            for (int i = 0; i < bintang1; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }

        public void titik(int titik1)
        {
            for (int i = 0; i < titik1; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

    }
}
