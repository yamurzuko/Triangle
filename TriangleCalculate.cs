using System;

namespace Triangle
{
    public class TriangleCalcule
    {
        public void Triangle(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j < value*2; j++)
                {
                    if (j == (11 - i + 1) || j == (11 + i - 1))
                    {
                        Console.Write("* ");
                    }
                    else if (i == value )        
                    {
                        Console.Write("* ");
                    }
                     else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}