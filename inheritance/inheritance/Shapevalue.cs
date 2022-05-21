using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Rectangle:Shape
    {
        public Rectangle (decimal l, decimal b)//constructor name same as class name=>automatically calls while define new
        {
            Length = l;
            Breadth = b;
        }
       
        public decimal Area()
        {
            return Length * Breadth;
        }
        public decimal Perimeter()
        {
            return 2 * (Length + Breadth);
        }
    }
}
