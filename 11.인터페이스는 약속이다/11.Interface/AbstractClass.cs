using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interface
{
    // 추상 클래스 => 구현 가능, 인스턴스x
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        // 추상메소드 => 상속할 경우 반드시 포함하여야 함
        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class AbstractClass
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
