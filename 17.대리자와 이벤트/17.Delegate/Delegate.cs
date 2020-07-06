using System;

//namespace _17.Delegate
//{
//    // 대리자 선언
//    delegate int MyDelegate(int a, int b);

//    class Calculator
//    {
//        // 대리자는 인스턴스 메소드도 참조 가능
//        public int Plus(int a, int b)
//        {
//            return a + b;
//        }
//        // 대리자는 정적 메소드도 참조 가능
//        public static int Minus(int a, int b)
//        {
//            return a - b;
//        }
//    }
//    class Delegate
//    {
//        static void Main(string[] args)
//        {
//            Calculator Calc = new Calculator();
//            MyDelegate Callback;

//            // 대리자의 인스턴스를 생성
//            Callback = new MyDelegate(Calc.Plus);
//            Console.WriteLine(Callback(3, 4));

//            Callback = new MyDelegate(Calculator.Minus);
//            Console.WriteLine(Callback(7, 5));
//        }
//    }
//}
