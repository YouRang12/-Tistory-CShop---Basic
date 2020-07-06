using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Method
{
    class LocalFunction
    {
        // 대문자를 소문자로 변경
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            // 로컬 함수 선언
            char ToLowerChar(int i)
            {
                // A ~ Z의 ASCII 값 : 65 ~ 90
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                // a ~ z의 ASCII 값 : 97 ~ 122
                else
                    return (char)(arr[i] + 32);
            }
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#"));
        }
    }
}
