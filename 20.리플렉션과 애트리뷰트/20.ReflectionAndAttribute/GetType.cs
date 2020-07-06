using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

// 리플렉션 => 객체의 형식(Type) 정보를 들여다보는 기능
//namespace _20.ReflectionAndAttribute
//{
//    // GetType => 객체의 형식 정보를 반환
//    // 형식 이름, 소속되어 있는 어셈블리 이름, 프로퍼티 목록
//    // 필드 목록, 이벤트 목록, 인터페이스의 목록
//    class GetType
//    {
//        static void PrintInterfaces(Type type)
//        {
//            Console.WriteLine("------ Interfaces ------ ");

//            // GetInterfaces() => 해당 형식이 상속하는 인터페이스 목록을 반환
//            Type[] interfaces = type.GetInterfaces();
//            foreach (Type i in interfaces)
//                Console.WriteLine("Name:{0}", i.Name);
//        }
//        static void PrintFields(Type type)
//        {
//            Console.WriteLine("------ Fields ------ ");

//            // GetFields() => 해당 형식의 필드 목록을 반환
//            FieldInfo[] fields = type.GetFields(
//                BindingFlags.NonPublic |
//                BindingFlags.Public |
//                BindingFlags.Static |
//                BindingFlags.Instance);

//            foreach (FieldInfo field in fields)
//            {
//                String accessLevel = "protected";
//                if (field.IsPublic) accessLevel = "public";
//                else if (field.IsPrivate) accessLevel = "private";

//                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}",
//                    accessLevel, field.FieldType.Name, field.Name);
//            }
//            Console.WriteLine();
//        }
//        static void PrintMethods(Type type)
//        {
//            Console.WriteLine("------ Methods ------ ");

//            // GetMethods() => 해당 형식의 메소드 목록을 반환
//            MethodInfo[] methods = type.GetMethods();
//            foreach (MethodInfo method in methods)
//            {
//                Console.Write("Type:{0}, Name:{1}, Parameter:",
//                    method.ReturnType.Name, method.Name);

//                ParameterInfo[] args = method.GetParameters();
//                for (int i = 0; i < args.Length; i++)
//                {
//                    Console.Write("{0}", args[i].ParameterType.Name);
//                    if (i < args.Length - 1)
//                        Console.Write(", ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }
//        static void PrintProperties(Type type)
//        {
//            Console.WriteLine("------ Properties ------ ");

//            // GetProperties() => 해당 형식의 프로퍼티 목록을 반환
//            PropertyInfo[] properties = type.GetProperties();

//            foreach (PropertyInfo property in properties)
//                Console.WriteLine("Type:{0}, Name:{1}",
//                    property.PropertyType.Name, property.Name);

//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            int a = 0;
//            Type type = a.GetType();

//            PrintInterfaces(type);
//            PrintFields(type);
//            PrintProperties(type);
//            PrintMethods(type);
//        }
//    }
//}
