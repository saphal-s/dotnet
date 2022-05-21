// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Exception_Handling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();

                int a = int.Parse(input);
                Console.WriteLine(a);
            }
            catch (FormatException ex) //ioexception
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
