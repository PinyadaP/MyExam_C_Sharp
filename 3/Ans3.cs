using System;

class Triangleinverse
{
    static void Main(string[] args)
    {
        int height = 5;
        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}