namespace HierrachicalExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 15);
            Square s = new Square(10);
            r.Area();
            s.Area();
        }
    }
}
