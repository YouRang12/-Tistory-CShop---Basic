using System;
using System.Collections.Generic;
using System.Collections;

namespace _15.Generic
{
    // foreach를 사용할 수 있는 일반화 클래스
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
        // IEnumerator<T> 형식의 객체를 반환
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        // 컬렉션의 현재 요소를 반환
        public T Current
        {
            get { return array[position]; }
        }
        // 컬렉션의 현재 요소를 반환(IEnumerator로부터 상속받은 프로퍼티)
        object IEnumerator.Current
        {
            get { return array[position]; }
        }
        // 컬렉션의 끝을 지난 경우 false, 이동이 성공한 경우 true
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }
        // 컬렉션의 첫 번째 위치의 "앞"으로 이동
        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {

        }
    }

    class EnumerableGeneric
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                Console.WriteLine(str);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (int no in int_list)
                Console.WriteLine(no);
        }
    }
}
