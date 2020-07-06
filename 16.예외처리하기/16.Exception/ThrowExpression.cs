using System;

//namespace _16.Exception
//{
//    class ThrowExpression
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                int? a = null;
//                int b = a ?? throw new ArgumentNullException();
//            }
//            // 예외발생 => ArgumentNullException
//            // null 참조를 올바른 인수로 받아들이지 않은 메서드에서 발생하는 예외
//            catch (ArgumentNullException e)
//            {
//                Console.WriteLine(e);
//            }

//            try
//            {
//                int[] array = new[] { 1, 2, 3 };
//                int index = 4;
//                int value = array[
//                    index >= 0 && index < 3
//                    ? index : throw new IndexOutOfRangeException()
//                    ];
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine(e);
//            }
//        }
//    }
//}
