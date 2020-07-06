using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _11.Interface
//{
//    interface IRunnable
//    {
//        void Run();
//    }

//    interface IFlyable
//    {
//        void Fly();
//    }

//    //인터페이스를 이용한 다중 상속기능
//    class FlyingCar : IRunnable, IFlyable
//    {
//        public void Run()
//        {
//            Console.WriteLine("Run! Run!");
//        }

//        public void Fly()
//        {
//            Console.WriteLine("Fly! Fly!");
//        }
//    }

//    class MultiInterfaceInheritance
//    {
//        static void Main(string[] args)
//        {
//            FlyingCar car = new FlyingCar();
//            car.Run();
//            car.Fly();

//            IRunnable runnable = car as IRunnable;
//            runnable.Run();

//            IFlyable flyable = car as IFlyable;
//            flyable.Fly();
//        }
//    }
//}
