using System;

//namespace _13.Array
//{
//    class MoreOnArray
//    {
//        private static bool CheckPassed(int score)
//        {
//            if (score >= 60)
//                return true;
//            else
//                return false;
//        }

//        private static void Print(int value)
//        {
//            Console.Write($"{value} ");
//        }

//        static void Main(string[] args)
//        {
//            int[] scores = new int[] { 80, 74, 81, 90, 34 };

//            foreach (int score in scores)
//                Console.Write($"{score} ");
//            Console.WriteLine();

//            // Sort => 배열을 정렬
//            System.Array.Sort(scores);

//            // ForEach<T>() => 배열의 모든 요소에 동일한 작업을 수행하게 함
//            System.Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            // Rank => 배열의 차원을 반환
//            Console.WriteLine($"Number of dimensions : {scores.Rank}");

//            // BinarySearch => 2진 탐색을 수행
//            Console.WriteLine("Binary Search : 81 is at {0}",
//                System.Array.BinarySearch<int>(scores, 81));

//            // IndexOf => 배열을 찾고자 하는 특정 데이터의 인덱스를 반환
//            Console.WriteLine("Linear Search : 90 is at {0}",
//                System.Array.IndexOf(scores, 90));

//            // TrueForAll => 배열의 모든 요소가 조건에 부합하는지의 여부를 반환
//            Console.WriteLine("Everyone passed ? : {0}",
//                System.Array.TrueForAll<int>(scores, CheckPassed));
            
//            // FindIndex<T>() => 배열에서 지정한 조건에 부합하는 첫 번째 요소의 인덱스를 반환
//            int index = System.Array.FindIndex<int>(scores,
//                delegate (int score)
//                {
//                    if (score < 60)
//                        return true;
//                    else
//                        return false;
//                });

//            scores[index] = 61;

//            // TrueForAll<T> => 배열의 모든 요소가 지정한 조건에 부합하는지의 여부를 반환
//            Console.WriteLine("Everyone passed ? : {0}",
//                System.Array.TrueForAll<int>(scores, CheckPassed));

//            // GetLenth() => 배열에서 지정한 차원의 길이를 반환
//            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");

//            // Resize => 배열의 크기를 재조정
//            System.Array.Resize<int>(ref scores, 10);

//            Console.WriteLine($"New length of scores : {scores.Length}");

//            System.Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            // Clear => 배열의 요소를 초기화
//            System.Array.Clear(scores, 3, 7);

//            System.Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();
//        }
//    }
//}
