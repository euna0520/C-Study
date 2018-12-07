using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study03
{
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            Console.ReadKey();
        }
    }
}
