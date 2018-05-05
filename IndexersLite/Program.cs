using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersLite
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayForIndexer arrayForIndexer = new ArrayForIndexer();

            for (int i = 0; i < arrayForIndexer.arr.Length; i++)
            {
                Console.WriteLine($"Index {i} Value {arrayForIndexer.arr[i]}");
            }

            Console.WriteLine("\n");

            arrayForIndexer[0] = 5;
            arrayForIndexer[1] = 4;
            arrayForIndexer[2] = 10;
            arrayForIndexer[3] = 3;

            for (int i = 0; i < arrayForIndexer.arr.Length; i++)
            {
                Console.WriteLine($"Index {i} Value {arrayForIndexer.arr[i]}");
            }


        }
    }
}
