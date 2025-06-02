using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}
