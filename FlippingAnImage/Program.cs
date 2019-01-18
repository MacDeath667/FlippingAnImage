using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1,1,0,1 },
                new int[] { 1,1,0,1 },
                new int[] { 1,0,0,0 },
                new int[] { 0,1,0,1 }
            };

            Solution solution = new Solution();
            WritelnMatrix(jaggedArray2);
            jaggedArray2 = solution.FlipAndInvertImage(jaggedArray2);
            WritelnMatrix(jaggedArray2);
        }

        private static void WritelnMatrix(int[][] matrix)
        {
            foreach (var m in matrix)
            {
                foreach (var i in m)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int buffer = 0;
            foreach (var a in A)
            {
                for (int c = 0; c < a.Length; c++)
                {
                    if (a[c] == 0)
                        a[c] = 1;
                    else
                        a[c] = 0;
                }

            }

            foreach (var a in A)
            {
                for (int c = 0; c < a.Length/2; c++)
                {
                    buffer = a[c];
                    a[c] = a[a.Length - 1 - c];
                    a[a.Length - 1 - c] = buffer;
                }
            }
            return A;
        }
    }
}
