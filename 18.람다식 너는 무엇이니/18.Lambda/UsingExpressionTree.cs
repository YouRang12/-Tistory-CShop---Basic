using System;
using System.Linq.Expressions;

//namespace _18.Lambda
//{
//    // 식 트리
//    class UsingExpressionTree
//    {
//        static void Main(string[] args)
//        {
//            // 1 * 2 + (x - y)
//            Expression const1 = Expression.Constant(1);
//            Expression const2 = Expression.Constant(2);

//            // 1 * 2;
//            Expression leftExp = Expression.Multiply(const1, const2);

//            // x를 위한 변수
//            Expression param1 =
//                Expression.Parameter(typeof(int));

//            // y를 위한 변수
//            Expression param2 =
//                Expression.Parameter(typeof(int));

//            // x - y
//            Expression rightExp = Expression.Subtract(param1, param2);

//            Expression exp = Expression.Add(leftExp, rightExp);

//            Expression<Func<int, int, int>> expression =
//                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
//                    exp, new ParameterExpression[]
//                    {
//                        (ParameterExpression)param1,
//                        (ParameterExpression)param2 });

//            // 실행가능한 코드로 컴파일
//            Func<int, int, int> func = expression.Compile();

//            // x = 7, y = 8
//            Console.WriteLine($"1 * 2 + ({7} - {8}) = {func(7, 8)}");
//        }
//    }
//}
