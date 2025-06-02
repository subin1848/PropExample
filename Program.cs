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
            //Product p1 = new Product("사과", 2000);
            // 팩토리 메서드 패턴 - private 생성자 사용
            Product p = Product.getInstance("바나나", 2000);

            // 정적 생성자 예제1
            //Console.WriteLine("첫 번째 위치");
            //Console.WriteLine(Sample.value);    //Sample.value 값 조회 전에 정적 생성자 호출
            //Console.WriteLine("두 번째 위치");
            //Sample sample = new Sample();
            //Console.WriteLine("세 번째 위치");

            // 정적 생성자 예제2
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();         //Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);   
            Console.WriteLine("세 번째 위치");

        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input) { return true; }
    }
}
