using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace _09.Class
//{
//    class Global
//    {
//        // static은 정적이라는 뜻을 가진 한정자.
//        // 프로그램 전체에 걸쳐 공유해야 하는 변수가 있다면 정적 필드를 이용.
//        public static int Count = 0;
//    }
    
//    class ClassA
//    {
//        public ClassA()
//        {
//            Global.Count++;
//        }
//    }

//    class ClassB
//    {
//        public ClassB()
//        {
//            Global.Count++;
//        }
//    }

//    class StaticField
//    {
//        static void Main()
//        {
//            Console.WriteLine($"Global.Count : {Global.Count}");

//            new ClassA();   // Count++ => 1
//            new ClassA();   // Count++ => 2
//            new ClassB();   // Count++ => 3
//            new ClassB();   // Count++ => 4

//            Console.WriteLine($"Global.Count : {Global.Count}");
//        }
//    }
//}
