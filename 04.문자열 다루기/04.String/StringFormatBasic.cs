using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _04.String
{
    class StringFormatBasic
    {
        static void Main(string[] args)
        {
            string result1 = string.Format("{0}DEF", "ABC");
            WriteLine("{0}", result1);

            string result2 = string.Format("{0, -10}DEF", "ABC");
            WriteLine("{0}", result2);

            string result3 = string.Format("{0, 10}DEF", "ABC");
            WriteLine("{0}", result3);
        }
    }
}
