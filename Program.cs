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
            TestOver(3);
        }

        // 오버로딩 주의점
        public static int TestOver(int input) { return 0; }
        public static bool TestOver(double input2) { return true; }
    }
}
