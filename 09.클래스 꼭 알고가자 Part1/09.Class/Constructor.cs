using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace _09.Class
//{
//    class Cat
//    {
//        public string Name;
//        public string Color;

//        // 생성자: 클래스와 이름이 같고, 설정된 값을 기준으로 생성.
//        // 생성자를 구현하지 않아도 자동으로 기본 생성자가 생성됨.
//        public Cat()
//        {
//            Name = "";
//            Color = "";
//        }

//        // 오버로딩 가능
//        public Cat(string _Name, string _Color)
//        {
//            Name = _Name;
//            Color = _Color;
//        }

//        // 종료자: CLR의 가비지 컬렉터가 객체가 소멸되는 시점을 판단해서 종료자를 호출.
//        // 오버로딩X, 직접 호출X, 언제 동작할지 예측할 수 없다.
//        ~Cat()
//        {
//            Console.WriteLine($"{Name} : 잘가");
//        }

//        public void Meow()
//        {
//            Console.WriteLine("{0} : 야옹", Name);
//        }
//    }

//    class Constructor
//    {
//        static void Main(string[] args)
//        {
//            Cat kitty = new Cat("키티", "하얀색");
//            kitty.Meow();
//            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

//            Cat nero = new Cat("네로", "검은색");
//            nero.Meow();
//            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
//        }
//    }
//}
