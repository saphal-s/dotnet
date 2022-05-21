// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Destructor
{
    public class Program
    {
        ~Rectangle()
        {
            Console.WriteLine("Destroyed")
        }
    }
}