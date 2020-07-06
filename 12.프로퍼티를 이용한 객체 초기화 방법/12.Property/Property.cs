using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _12.Property
//{
//    class BirthdayInfo
//    {
//        // 프로퍼티 => 은닉성과 편의성 
//        // 접근한정자 데이터형식 필드이름
//        private string name;
//        private DateTime birthday;

//        // 접근한정자 데이터형식 프로퍼티이름
//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }

//        public DateTime Birthday
//        {
//            get
//            {
//                return birthday;
//            }

//            set
//            {
//                birthday = value;
//            }
//        }

//        // 읽기전용 프로퍼티(set 사용x)
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
//            }
//        }
//    }

//    class Property
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo();
//            birth.Name = "유랑";
//            birth.Birthday = new DateTime(1990, 2, 10);

//            Console.WriteLine($"Name : {birth.Name}");
//            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birth.Age}");
//        }
//    }
//}
