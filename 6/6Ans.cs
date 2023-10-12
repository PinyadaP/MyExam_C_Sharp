using System;

class Program
{
    static void Main()
    {
        int[] inputNumbers = { 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 };
        SortNumbers(inputNumbers);
        Console.WriteLine("ผลลัพธ์: " + string.Join(", ", inputNumbers));
    }

    static void SortNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    // สลับค่าของตัวแปร numbers[i] และ numbers[j]
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
    }
}
