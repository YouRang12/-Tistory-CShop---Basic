using System;

//namespace _16.Exception
//{
//    class FilterableException : System.Exception
//    {
//        public int ErrorNo { get; set; }
//    }

//    class ExceptionFiltering
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Number Between 0~10");
//            string input = Console.ReadLine();
//            try
//            {
//                int num = Int32.Parse(input);

//                if (num < 0 || num > 10)
//                    throw new FilterableException() { ErrorNo = num };
//                else
//                    Console.WriteLine($"Output : {num}");
//            }
//            // 예외 필터
//            catch (FilterableException e) when (e.ErrorNo < 0)
//            {
//                Console.WriteLine("Negative input is not allowed.");
//            }
//            catch(FilterableException e) when (e.ErrorNo > 10)
//            {
//                Console.WriteLine("Too big number is now allowed.");
//            }
//        }
//    }
//}
