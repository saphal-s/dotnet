using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle { Length = 10, Breadth = 5 };
            Rectangle R2 = new Rectangle { Length = 15, Breadth = 10 };
            Rectangle R3 = R1 + R2;
            
            Console.WriteLine(R3.Length);
        }
    }
}
