using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Operator2
{
    class AssignmentOperator
    {
        static void Main(string[] args)
        {
            int a;

            // = 할당 연산자
            // 오른쪽 피연산자를 왼쪽 피연산자에게 할당.
            a = 100;
            Console.WriteLine($"a = 100 : {a}");

            // += 덧셈 할당 연선자
            // a += b;는 a=a+b;와 같다.
            a += 90;
            Console.WriteLine($"a += 90 : {a}");

            // -= 뺄셈 할당 연산자
            // a -= b;는 a=a-b;와 같다.
            a -= 80;
            Console.WriteLine($"a -= 80 : {a}");

            // *= 곱셈 할당 연산자
            // a *= b;는 a=a*b;와 같다.
            a *= 70;
            Console.WriteLine($"a *= 70 : {a}");

            // /= 나눗셈 할당 연산자
            // a /= b;는 a=a/b;와 같다.
            a /= 60;
            Console.WriteLine($"a /= 60 : {a}");

            // %= 나머지 할당 연산자
            // a %= b;는 a=a%b;와 같다.
            a %= 50;
            Console.WriteLine($"a %= 50 : {a}");

            // &= 논리곱 할당 연산자
            // a &= b;는 a=a&b;와 같다.
            a &= 40;
            Console.WriteLine($"a &= 40 : {a}");

            // |= 논리곱 할당 연산자
            // a |= b;는 a=a|b;와 같다.
            a |= 30;
            Console.WriteLine($"a |= 30 : {a}");

            // ^= 배타적 논리합 할당 연산자
            // a ^= b;는 a=a^=와 같다.
            a ^= 20;
            Console.WriteLine($"a ^= 20 : {a}");

            // <<= 왼쪽 시프트 할당 연산자
            // a <<= b;는 a=<<b;와 같다.
            a <<= 10;
            Console.WriteLine($"a <<= 10: {a}");

            // >>= 오른쪽 시프트 할당 연산자
            // a >>= b;는 a=a>>b;와 같다.
            a >>= 1;
            Console.WriteLine($"a >>= 1 : {a}");
        }
    }
}
