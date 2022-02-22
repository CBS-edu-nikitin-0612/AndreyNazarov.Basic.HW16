using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 10, 10);
            Point point2 = new Point(20, 20, 20);

            Console.WriteLine(point1);
            Console.WriteLine(point2);
            point1 = point2 + point1;
            Console.WriteLine(point1);
        }
    }
}
