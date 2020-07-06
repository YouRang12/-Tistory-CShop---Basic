using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _10.Class2
//{
//    class Base
//    {
//        public void MyMethod()
//        {
//            Console.WriteLine("Base.MyMethod()");
//        }
//    }

//    class Derived : Base
//    {
//        // 메소드 숨기기 => new 한정자를 통해서 부모(기반) 클래스의 메소드를 감추고,
//        //                자식(파생) 클래스의 구현된 기능만 보여줌
//        public new void MyMethod()
//        {
//            Console.WriteLine("Derived.MyMethod()");
//        }
//    }

//    class MethodHiding
//    {
//        static void Main(string[] args)
//        {
//            Base baseObj = new Base();
//            baseObj.MyMethod();

//            Derived derivedObj = new Derived();
//            derivedObj.MyMethod();

//            // 객체 선언을 다음과 같이 설정해야 부모 클래스 메소드가 보임
//            Base baseOrDerived = new Derived();
//            baseOrDerived.MyMethod();
//        }
//    }
//}
