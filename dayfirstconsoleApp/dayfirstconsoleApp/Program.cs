using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayfirstconsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Student student = new Student(1, "saphal");
            Console.WriteLine(student.Id);

        }
    }
}
