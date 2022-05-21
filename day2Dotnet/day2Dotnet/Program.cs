// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*public class Student
{
    public int id { get; set; }//internal private variable banauxa ani tesma kam garxa
    public string name { get; set; } //get set init are accessors =>properties, private init id =>field
}*/

//accessors 
namespace day2Dotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Time T = new Time();
            T.Hours = 2;
            /*Console.WriteLine($"The seconds is  { T.Minutes}");
            Console.WriteLine(T.Seconds);*/
            Console.WriteLine("The Minutes is " + T.Minutes + ". The Seconds is " + T.Seconds + ".");
        } 

    }
}
