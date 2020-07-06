using System;

namespace _17.Delegate
{
    // 대리자 선언
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if ( temp != 0 && temp % 3 == 0)
            {
                // number가 '3', '6', '9'로 끝날 때 이벤트 발생
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }

    class EventTest
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            // SomethingHappened 이벤트에 MyHandler() 메소드를 이벤트 핸들러로 등록
            notifier.SomethingHappened += new EventHandler(MyHandler);
            
            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
