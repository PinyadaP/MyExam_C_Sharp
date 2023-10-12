using System;


    class TestFindNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            int Sum = 6;
            Boolean IsTrue = true;

            Console.WriteLine("ผลลัพธ์ที่มีผลรวมเป็น {0} {1} คือ:", Sum, IsTrue);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == Sum)
                    {
                        Console.WriteLine("{0},{1}", arr[i], arr[j]);
                    }
                }
            }

            Console.ReadKey();
        }
    }

