using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Operator
{
    class RelationalOperator
    {
        static void Main(string[] args)
        {
            // > 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자보다 크면 참, 아니면 거짓
            Console.WriteLine($"3 > 4 : {3 > 4}");

            // >= 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자보다 크거나 같으면 참, 아니면 거짓
            Console.WriteLine($"3 >= 4 : {3 >= 4}");

            // < 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자보다 작으면 참, 아니면 거짓
            Console.WriteLine($"3 < 4 : {3 < 4}");

            // <= 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자보다 작거나 같으면 참, 아니면 거짓
            Console.WriteLine($"3 <= 4 : {3 <= 4}");

            // == 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자와 같으면 참, 아니면 거짓
            Console.WriteLine($"3 == 4 : {3 == 4}");

            // != 연산자
            // 왼쪽 피연산자가 오른쪽 피연산자와 다르면 참, 아니면 거짓
            Console.WriteLine($"3 != 4 : {3 != 4}");
        }
    }
}
