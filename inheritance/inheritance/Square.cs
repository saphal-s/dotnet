using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Square:Shape
    {
        public Square (decimal l)
        {
            Length = l;
        }
        public decimal Area()
        {
            return Length * Length;
        }
        public decimal Perimeter()
        {
            return 4 * Length;
        }
    }
}
