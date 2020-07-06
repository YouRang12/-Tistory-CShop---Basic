using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _12.Property
//{
//    interface INamedValue
//    {
//        // 인터페이스의 프로퍼티에 대해서는 자동 구현x
//        string Name
//        {
//            get;
//            set;
//        }

//        string Value
//        {
//            get;
//            set;
//        }
//    }

//    // 인터페이스를 상속하므로 
//    class NameValue : INamedValue
//    {
//        public string Name
//        {
//            get;
//            set;
//        }

//        public string Value
//        {
//            get;
//            set;
//        }
//    }

//    class PropertiesInInterface
//    {
//        static void Main(string[] args)
//        {
//            NameValue name = new NameValue()
//            { Name = "이름", Value = "유랑" };

//            NameValue height = new NameValue()
//            { Name = "키", Value = "180Cm" };

//            NameValue weight = new NameValue()
//            { Name = "몸무게", Value = "90Kg" };

//            Console.WriteLine($"{name.Name} : {name.Value}");
//            Console.WriteLine($"{height.Name} : {height.Value}");
//            Console.WriteLine($"{weight.Name} : {weight.Value}");
//        }
//    }
//}
