namespace Csharp_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interval i1 = new Interval(1, 10);
            Console.WriteLine(i1);
            Interval i2 = new Interval(-2, 4);
            Console.WriteLine(i2);
            Console.WriteLine("8 is withing intervals: " + i1.isInterval(8) + ", " + i2.isInterval(8));

            Console.WriteLine(Interval.getIntersection(i1, i2));


            Line l = new Line(5);
            Console.Write(l.draw());
        }
    }
} 