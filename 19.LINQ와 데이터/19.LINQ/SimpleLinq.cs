using System;
using System.Linq;

//namespace _19.LINQ
//{
//    class Profile
//    {
//        public string Name { get; set; }
//        public int Height { get; set; }
//    }

//    class SimpleLinq
//    {
//        static void Main(string[] args)
//        {
//            Profile[] arrProfile =
//            {
//                new Profile(){Name = "정수성", Height = 186 },
//                new Profile(){Name = "김태희", Height = 158 },
//                new Profile(){Name = "고현정", Height = 172 },
//                new Profile(){Name = "이문세", Height = 178 },
//                new Profile(){Name = "하하", Height = 171 }
//            };
//            // LINQ 쿼리식
//            // from => 어떠 데이터 집합에서 찾을 것인가?
//            // where => 어떤 값의 데이터를 찾을 것인가?
//            // orderby => 데이터 정렬을 어떻게 할 것인가?
//            // select => 어떤 항목을 추출할 것인가?
//            var profiles = from profile in arrProfile
//                           where profile.Height < 175
//                           orderby profile.Height
//                           select new
//                           {
//                               Name = profile.Name,
//                               InchHeight = profile.Height * 0.393
//                           };

//            foreach (var profile in profiles)
//                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
//        }
//    }
//}
