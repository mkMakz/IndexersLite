using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersLite
{
    public class ArrayForIndexer
    {
        private Random rand = new Random();

        public int[] arr = new int[10] { 10, 3, 6, 1, 2, 5, 7, 4, 3, 12};

        public int this[int ind]
        {

            get
            {
                return arr[ind];
            }
            set
            {
                arr[ind] = (int)Math.Pow(value, 2);
            }
        }

        



    }
}
