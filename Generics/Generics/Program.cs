namespace Generics
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Student<string> S = new Student<string>();
            Student<int> S1 = new Student<int>();

            S.marks[0] = "Ten";
            S1.marks[1] = 10;

            Console.WriteLine(S.marks[0]);
            
            Console.WriteLine(S1.marks[1]);
        } 
    }
}
