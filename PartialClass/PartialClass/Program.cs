using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.indexer
{
    internal class Program
    {
        public static void Main()
        {
            Mycollection m = new Mycollection();

            Console.WriteLine(m["One"]);
        }
    }
}
