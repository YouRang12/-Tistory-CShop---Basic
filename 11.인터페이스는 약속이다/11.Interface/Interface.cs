using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//namespace _11.Interface
//{
//    // 인터페이스 이름 앞에 I를 붙이는 것은 프로그래머들의 약속
//    interface ILogger
//    {
//        void WriteLog(string message);
//    }

//    class ConsoleLogger : ILogger
//    {
//        // 인터페이스를 상속받으면 반드시 메소드까지 구현해야 함
//        // 이 메소드들은 public 한정자로 수식해야 한다
//        public void WriteLog(string message)
//        {
//            Console.WriteLine(
//                            "{0} {1}",
//                            DateTime.Now.ToLocalTime(), message);
            
//        }
//    }

//    class FileLogger : ILogger
//    {
//        private StreamWriter writer;

//        public FileLogger(string path)
//        {
//            writer = File.CreateText(path);
//            writer.AutoFlush = true;
//        }

//        public void WriteLog(string message)
//        {
//            writer.WriteLine("{0} {1}",
//                            DateTime.Now.ToShortTimeString(), message);
//        }
//    }

//    class ClimateMonitor
//    {
//        private ILogger logger;
//        public ClimateMonitor(ILogger logger)
//        {
//            this.logger = logger;
//        }

//        public void start()
//        {
//            while (true)
//            {
//                Console.Write("온도를 입력해 주세요.: ");
//                string temperature = Console.ReadLine();
//                if (temperature == "")
//                    break;
//                logger.WriteLog("현재 온도 : " + temperature);
//            }
//        }
//    }

//    class Interface
//    {
//        static void Main(string[] args)
//        {
//            // monitor 객체는 애플리케이션이 시작된 디렉토리에
//            // MyLog.txt를 만들고 여기에 로그를 남긴다
//            ClimateMonitor monitor = new ClimateMonitor(
//                new FileLogger("MyLog.txt"));

//            monitor.start();
//        }
//    }
//}
