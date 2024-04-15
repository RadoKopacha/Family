namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 pravoygylnik = new Class1();
            pravoygylnik.a = 7;
            pravoygylnik.b = 6;
            Console.WriteLine("P of Squear");
            Console.WriteLine(pravoygylnik.Perimetyr());
            Console.WriteLine("Area of Square");
            Console.WriteLine(pravoygylnik.findArea());
            triygylnik rectangle = new triygylnik();
            rectangle.sidea = 8;
            rectangle.sideb = 7;    
            rectangle.sidec = 10;
            rectangle.ha = 5;
            Console.WriteLine("P of Triangle");
            Console.WriteLine(rectangle.Perimetyr());
            Console.WriteLine("Ärea of Triangle");
            Console.WriteLine(rectangle.Area());
        }
  
    }
}
