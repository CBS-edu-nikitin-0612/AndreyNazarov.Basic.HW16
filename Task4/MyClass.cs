using System;

namespace Task4
{
    internal class MyClass
    {
        public DateTime date { get; set; }

        public static double operator -(MyClass inst1, MyClass inst2)
        {
            return (inst1.date - inst2.date).TotalDays;
        }
        public static MyClass operator +(MyClass myClass, double days)
        {
            return new MyClass() { date = myClass.date.AddDays(days) };
        }
    }
}
