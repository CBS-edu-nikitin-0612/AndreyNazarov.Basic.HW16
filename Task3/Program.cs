using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До обновления");
            House house = new House("House1", "ASD", 5, 5);
            House houseClone = (House)house.Clone();
            House houseDeepClone = house.DeepClone();
            Console.WriteLine(house);
            Console.WriteLine(houseClone);
            Console.WriteLine(houseDeepClone);
            Console.WriteLine("\nПосле обновленния");
            house.Update();
            Console.WriteLine(house);
            Console.WriteLine(houseClone);
            Console.WriteLine(houseDeepClone);
        }
    }
}
