using System;

namespace _16.Exception
{
    class StackTrace
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            // 예외를 이용 효과적인 디버깅처리를 해보자
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
