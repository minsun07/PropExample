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
        }

        // 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input2) { return true; }
    }
}
