namespace Task6
{
    internal struct Point
    {
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z:{Z}";
        }
    }
}
