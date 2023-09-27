namespace SquareLib
{
    public static class Square
    {
        public static double TriangleArea(double a, double b, double c)
        {
            var MaxSide = Math.Max(c, Math.Max(a, b));
            var MinSide = Math.Min(c, Math.Min(a, b));
            var AvgSide = a + b + c - MinSide - MaxSide;
            if (MinSide <= 0) return 0; // Если минимальная стотроная имеет не положительную длину, то есть минимум одна сторона с несуществующей длинной
            if (MinSide + AvgSide <= MaxSide) return 0; // Проверка на существование треугольника
            if (MinSide * MinSide + AvgSide * AvgSide == MaxSide * MaxSide) // Проверка на прямоугольность
            {
                return MinSide * AvgSide / 2;
            }
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double CircleArea(double radius)
        {
            if (radius <= 0) return 0; 
            return Math.PI * radius * radius;
        }
    }
}