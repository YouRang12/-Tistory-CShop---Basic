using System;
using System.Runtime.CompilerServices;

// 애트리뷰트 => 코드에 대한 부가 정보를 기록하고 읽을 수 있는 기능
namespace _20.ReflectionAndAttribute
{
    public static class Trace
    {
        public static void WriteLine(string message,
            // CallerFilePath => 현재 메소드가 호출된 소스 파일 경로를 나타냄
            [CallerFilePath] string file = "",
            // CallerLineNumber => 현재 메소드가 호출된 소스 파일 내의 행번호를 나타냄
            [CallerLineNumber] int line = 0,
            // CallerMemberName => 현재 메소드를 호출한 메소드 또는 프로퍼티의 이름을 나타냄
            [CallerMemberName] string member = "")
        {
            Console.WriteLine(
                $"{file}(Line:{line}) {member}: {message}");
        }
    }

    class CallerInfo
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐거운 프로그래밍");
        }
    }
}
