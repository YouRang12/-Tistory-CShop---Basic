using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.Array
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            // 가변 배열
            // 데이터 형식[][] 배열이름 = new 데이터형식[가변 배열의 용량][ ];
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            int[][] jagged2 = new int[2][]
            {
                new int[] { 1000, 2000 },
                new int[4] {6, 7, 8, 9 }
            };

            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }
    }
}
