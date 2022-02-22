using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass() { date = DateTime.Parse("22/02/2022") };
            MyClass myClass2 = new MyClass() { date = DateTime.Parse("20/02/2022") };
            Console.WriteLine(myClass1 - myClass2);
            myClass1 += 10;
            Console.WriteLine(myClass1 - myClass2);
        }
    }
}
