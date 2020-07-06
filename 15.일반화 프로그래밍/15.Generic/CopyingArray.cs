using System;

//namespace _15.Generic
//{
//    class CopyingArray
//    {
//        // 일반화 메소드
//        // 한정자 반환 형식 메소드이름<형식 매개 변수> (매개 변수 목록)
//        static void CopyArray<T>(T[] source, T[] target)
//        {
//            for (int i = 0; i < source.Length; i++)
//                target[i] = source[i];
//        }

//        static void Main(string[] args)
//        {
//            int[] source = { 1, 2, 3, 4, 5 };
//            int[] target = new int[source.Length];

//            // 형식 매개 변수 T에 int를 대입
//            CopyArray<int>(source, target);

//            foreach (int element in target)
//                Console.WriteLine(element);

//            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
//            string[] target2 = new string[source2.Length];

//            CopyArray<string>(source2, target2);

//            foreach (string element in target2)
//                Console.WriteLine(element);
//        }
//    }
//}
