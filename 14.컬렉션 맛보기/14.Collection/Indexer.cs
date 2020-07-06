using System;
using System.Collections;

//namespace _14.Collection
//{
//    class MyList
//    {
//        private int[] array;

//        public MyList()
//        {
//            array = new int[3];
//        }

//        // index
//        // 한정자 인덱서 형식 this[형식 index] => index 이름 변경가능
//        public int this[int index]
//        {
//            get
//            {
//                return array[index];
//            }

//            set
//            {
//                if (index >= array.Length)
//                {
//                    Array.Resize<int>(ref array, index + 1);
//                    Console.WriteLine($"Array Resized : {array.Length}");
//                }
//                array[index] = value;
//            }
//        }

//        public int Length
//        {
//            get { return array.Length; }
//        }
//    }

//    class Indexer
//    {
//        static void Main(string[] args)
//        {
//            MyList list = new MyList();
//            for (int i = 0; i < 5; i++)
//                list[i] = i;

//            for (int i = 0; i < list.Length; i++)
//                Console.WriteLine(list[i]);
//        }
//    }
//}
