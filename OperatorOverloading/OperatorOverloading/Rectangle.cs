using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
	public class Rectangle
	{
		public decimal Length { get; set; }
		public decimal Breadth { get; set; }

		public static Rectangle operator +(Rectangle r1, Rectangle r2)
		{
			Rectangle r = new Rectangle
            {
				Length = r1.Length + r2.Length,
				Breadth = r1.Breadth + r2.Breadth
            };
			return r;
		}

	}
}
