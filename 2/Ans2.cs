using System;

class Triangle
{
    static void Main(string[] args)
    {
        int height = 6;
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
