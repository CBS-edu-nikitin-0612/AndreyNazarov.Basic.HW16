using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(10, 20, 30, 40);
            Block block2 = new Block(10, 20, 30, 40);
            Block block3 = new Block(100, 200, 300, 400);

            Console.WriteLine(block1);
            Console.WriteLine(block2);
            Console.WriteLine(block3);

            Console.WriteLine(block1.Equals(block2));
            Console.WriteLine(block1.Equals(block3));
        }
    }
}
