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

            // 기본 생성자(기정생성자)는 생성자가 없을 경우에만 자동으로 생성
            Product p1 = new Product("사과", 2000);
        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input) { return true; }
    }
}
