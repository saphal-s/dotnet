// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using inheritance;

namespace inheritance
{
    internal class Program
    {
       public static void Main(string[] args)//string args->user le diyeko input string args ma aauxa
        {
            Rectangle R = new Rectangle(4, 6);
            Console.WriteLine(R.Area());
            Console.WriteLine(R.Perimeter());

            Square S = new Square(4);
            Console.WriteLine(S.Area());
            Console.WriteLine(S.Perimeter());

        }
    }
}
