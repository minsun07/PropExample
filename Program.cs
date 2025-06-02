using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestOver(3L);

            // 생성자
            //Product p = new Product();  // 기본 생성자(기정생성자)
            //Product p = new Product("아아", 1500);
            // 팩토리 메서드 패턴 - private 생성자 사용
            Product p = Product.getInstance("뜨아", 1000);

            // 정적 생성자 예제 1
            //Console.WriteLine("첫 번째 위치");
            //Console.WriteLine(Sample.value);
            //Console.WriteLine("두 번째 위치");
            //Sample sample = new Sample();

            // 정적 생성자 패턴 2
            Console.WriteLine("첫 번째 위치");
            Sample sample2 = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);        // Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("세번째 위치");


            // const vs. readonly
            Item item1 = new Item("고구마", 1500);
            Item item2 = new Item("감자", 1000);
            Item item3 = new Item("옥수수", 2000);
            Item item4 = new Item("토란", 2500);

        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input2) { return true; }
    }
}
