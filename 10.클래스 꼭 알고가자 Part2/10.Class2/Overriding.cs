using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _10.Class2
//{
//    class ArmorSuite
//    {
//        // 오버라이딩 조건1) 부모 클래스 메소드를 virtual 키워드로 설정
//        // 오버라이딩 조건2) 부모 클래스 메소드를 public로 설정
//        public virtual void Initialize()
//        {
//            Console.WriteLine("Armored");
//        }
//    }

//    class IronMan : ArmorSuite
//    {
//        // 오버라이딩 조건3) 변경할 자식 클래스 메소드에 override 키워드로 설정
//        public override void Initialize()
//        {
//            // base 키워드 => 부모 클래스를 가리킴
//            base.Initialize();
//            Console.WriteLine("Repulsor Rays Armed");
//        }
//    }

//    class WarMachine : ArmorSuite
//    {
//        public override void Initialize()
//        {
//            base.Initialize();
//            Console.WriteLine("Double-Barrel Cannons Armed");
//            Console.WriteLine("Micro-Rocket Launcher Armed");
//        }
//    }

//    class Overriding
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("1)Creating ArmorSuite...");
//            ArmorSuite armorsuite = new ArmorSuite();
//            armorsuite.Initialize();

//            Console.WriteLine("\n2)Creating IronMan...");
//            ArmorSuite ironman = new IronMan();
//            ironman.Initialize();

//            Console.WriteLine("\n3)Creating WarMaching...");
//            ArmorSuite warmachine = new WarMachine();
//            warmachine.Initialize();
//        }
//    }
//}
