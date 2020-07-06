using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Class
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class TypeCasting
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                // mammal 객체가 Dog 형식임을 확인했으므로 안전하게 형식 변환이 이루어짐.
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;

            // mammal2가 Cat 형식 변환에 실패했다면 cat은 null이 된다.
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
