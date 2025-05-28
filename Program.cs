using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3);
        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        // int 타입 TestOver 메서드를 지워도 자동형변환이 되므로 double 타입의 TestOver 메서드로 간다.
        public static bool TestOver(double input) { return true; }
    }
}
