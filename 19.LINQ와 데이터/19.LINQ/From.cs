using System;
using System.Linq;

//namespace _19.LINQ
//{
//    class From
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

//            // LINQ의 범위 변수
//            // from => 어떠 데이터 집합에서 찾을 것인가?
//            // where => 어떤 값의 데이터를 찾을 것인가?
//            // orderby => 데이터 정렬을 어떻게 할 것인가?
//            // select => 어떤 항목을 추출할 것인가?

//            var result = from n in numbers
//                         where n % 2 == 0
//                         orderby n
//                         select n;

//            // freach 문의 반복 변수
//            foreach (int n in result)
//                Console.WriteLine($"짝수 : {n}");
//        }
//    }
//}
