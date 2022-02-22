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
    internal class Block
    {
        public Block(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }
        public int Side1 { get; private set; }
        public int Side2 { get; private set; }
        public int Side3 { get; private set; }
        public int Side4 { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Block temp = (Block)obj;

            return Side1 == temp.Side1 && Side2 == temp.Side2 && Side3 == temp.Side3 && Side4 == temp.Side4;
        }
        public override string ToString()
        {
            return $"Side 1: {Side1} Side 2: {Side2} Side 3: {Side3} Side 4: {Side4}";
        }

        public override int GetHashCode()
        {
            return (Side1 + Side2 + Side3 + Side4).GetHashCode();
        }
    }
}
