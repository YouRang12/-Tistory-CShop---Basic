using System;

//namespace _18.Lambda
//{
//    class Actiontest
//    {
//        static void Main(string[] args)
//        {
//            // Action 대리자는 반환형식이 없다.
//            Action act1 = () => Console.WriteLine("Action()");
//            act1();

//            int result = 0;
//            Action<int> act2 = (x) => result = x * x;

//            act2(3);
//            Console.WriteLine($"result : {result}");

//            Action<double, double> act3 = (x, y) =>
//            {
//                double pi = x / y;
//                Console.WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
//            };
//            act3(22.0, 7.0);
//        }
//    }
//}
