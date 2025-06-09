using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            // const vs readonly
            Item item1 = new Item("고구마", 1500);
            Item item2 = new Item("감자", 1000);
            Item item3 = new Item("옥수수", 2000);
            Item item4 = new Item("토란", 2500);
            Console.WriteLine(item1.id);
            //Item1.id;
            Console.WriteLine(item2.id);

            Console.WriteLine(Item.ApplicationName);

            Box box = new Box(100, 100);
            //Console.WriteLine(box.getHeight());
            //box.setWidth(200);
            //Console.WriteLine(box.Area());

            Console.WriteLine(box.Height);
            box.Width = 200;
            Console.WriteLine(box.Area);

            //값 복사 vs 참조 복사 비교
            //값 복사 (value)
            int a = 10;
            Change(a);
            Console.WriteLine(a);

            //참조 복사 (reference) - 객체의 레퍼런스(주소값)이 넘어가서 원본에 영향을 줌
            Test test = new Test();
            test.value = 10;
            Change(test);
            Console.WriteLine(test.value);  // test를 바로 출력하면 ToString()이 호출됨

            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);

            // 재귀함수를 이용한 피보나치수 구하기
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(50));
        }
        static void Change(int input)
        {
            input = 20;
        }
        // 주소를 가르켜서 원본 데이터가 수정이 됨
        static void Change(Test input)
        {
            input.value = 20;
        }
        class Test
        {
            public int value = 10;

            public override string ToString()
            {
                return value.ToString();
            }
        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input) { return true; }

        // 피보나치 
        public class Fibonacci
        {
            public static long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 0) { return 1; }
                if (i == 1) { return 1; }
                return Get(i - 1) + Get(i - 2);
            }
            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long GetM(int i)
            {
                long value = 0;
                if (memo.ContainsKey(i))
                {
                    value = memo[i];
                }
                else
                {
                    if(i < 0) { value = memo[i] = 0; }
                    if (i == 1) { value = memo[i] = 1; }
                    if (i == 2) { value = memo[i] = 1; }
                    if (i > 2)
                    {
                        memo[i] = GetM(i - 1) + GetM(i - 2);
                        value = memo[i];
                    }
                }
                return value;
            }
        }
    }
}
