using System;
using System.Collections;

namespace Task3
{
    internal class House : ICloneable
    {
        private string name;
        private string manufacurer;
        private ArrayList sizes;

        public House(string name, string manufacurer, int height, int width)
        {
            this.name = name;
            this.manufacurer = manufacurer;
            Height = height;
            Width = width;
            sizes = new ArrayList();
        }

        public int Height { get; private set; }
        public int Width { get; private set; }

        public void Update()
        {
            name += "-";
            manufacurer += "-";
            Height++;
            Width++;
            sizes = new ArrayList();
        }
        // Почему результат одинаковый для обоих методов, мне казалось что при использовании
        // MemberwiseClone на строковые с ссылочные типы должна была скопироваться ссылка
        public object Clone()
        {
            return MemberwiseClone();
        }

        public House DeepClone()
        {
            House clone = (House)MemberwiseClone();
            clone.name = string.Copy(name);
            clone.manufacurer = string.Copy(manufacurer);
            return clone;
        }

        public override string ToString()
        {
            return $"Name: {name} Manufacturer: {manufacurer} Height: {Height} Width: {Width} Sizes: {sizes.GetHashCode()}";
        }
    }
}
