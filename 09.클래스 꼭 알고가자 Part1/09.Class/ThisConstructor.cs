using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace _09.Class
//{
//    class MyClass
//    {
//        int a, b, c;

//        public MyClass()
//        {
//            this.a = 5425;
//            Console.WriteLine("MyClass()");
//        }

//        // this(): 자기 자신의 생성자를 가리킴.
//        public MyClass(int b) : this()
//        {
//            this.b = b;
//            Console.WriteLine($"MyClass({b})");
//        }

//        public MyClass(int b, int c) : this(b)
//        {
//            this.c = c;
//            Console.WriteLine($"MyClass({b}, {c})");
//        }

//        public void PrintFields()
//        {
//            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
//        }
//    }
//    class ThisConstructor
//    {
//        static void Main(string[] args)
//        {
//            MyClass a = new MyClass();
//            a.PrintFields();
//            Console.WriteLine();

//            MyClass b = new MyClass(1);
//            b.PrintFields();
//            Console.WriteLine();

//            MyClass c = new MyClass(10, 20);
//            c.PrintFields();
//        }
//    }
//}
