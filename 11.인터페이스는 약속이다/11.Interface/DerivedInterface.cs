using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _11.Interface
//{
//    interface Ilogger
//    {
//        void WriteLog(string message);
//    }

//    // 인터페이스도 인터페이스 상속이 가능
//    // 인터페이스 수정이 어려울 때 상속기능을 이용
//    interface IFormattableLogger : Ilogger
//    {
//        void WriteLog(string format, params Object[] args);
//    }

//    class ConsoleLogger2 : IFormattableLogger
//    {
//        public void WriteLog(string message)
//        {
//            Console.WriteLine("{0} {1}",
//                            DateTime.Now.ToLocalTime(), message);
//        }

//        public void WriteLog(string format, params Object[] args)
//        {
//            String message = String.Format(format, args);
//            Console.WriteLine("{0} {1}",
//                            DateTime.Now.ToLocalTime(), message);
//        }
//    }

//    class DerivedInterface
//    {
//        static void Main(string[] args)
//        {
//            IFormattableLogger logger = new ConsoleLogger2();
//            logger.WriteLog("The world is not flat.");
//            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
//        }
//    }
//}
