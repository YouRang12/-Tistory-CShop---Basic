using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace _13.Array
//{
//    class _2DArray
//    {
//        static void Main(string[] args)
//        {
//            // 배열을 초기화하는 방법1 => 배열의 형식과 길이를 명시
//            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            // 배열을 초기화하는 방법2 => 배열의 길이를 생략
//            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

//            for (int i = 0; i < arr2.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr2.GetLength(1); j++)
//                {
//                    Console.Write($"[{i}, {j}] : {arr2[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();

//            // 배열을 초기화하는 방법3 => 형식과 길이를 모두 생략
//            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

//            for (int i = 0; i < arr2.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr2.GetLength(1); j++)
//                {
//                    Console.Write($"[{i}, {j}] : {arr3[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }

//    }
//}
