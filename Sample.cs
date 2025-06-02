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
        ~Sample()   // Sample 소멸자 정의 - 객체가 소멸될 때 호출(GC 마음 or 프로그램 종료 시)
        {
            Console.WriteLine("Sample 객체 소멸자 호출");
        }
    }
}
