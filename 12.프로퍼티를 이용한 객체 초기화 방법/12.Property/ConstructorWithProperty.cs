using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _12.Property
//{
//    class BirthdayInfo
//    {
//        // 프로퍼티를 이용한 객체 초기화
//        public string Name
//        {
//            get;
//            set;
//        }

//        public DateTime Birthday
//        {
//            get;
//            set;
//        }

//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//    }
//    class ConstructorWithProperty
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo()
//            {
//                Name = "유랑",
//                Birthday = new DateTime(1990, 2, 10)
//            };

//            Console.WriteLine($"Name :{birth.Name}");
//            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");
//        }
//    }
//}
