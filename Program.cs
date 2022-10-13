using System;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            TriangleCalcule triangle = new TriangleCalcule();
            triangle.Triangle(number);
        }
    }
}