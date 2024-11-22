using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int numElements = int.Parse(Console.ReadLine());

        Random random = new Random();
        int[] array = new int[numElements];

        for (int i = 0; i < numElements; i++)
        {
            array[i] = random.Next(-30, 46);
        }

        for (int i = 0; i < numElements; i++)
        {
            Console.Write(array[i] + "\t");
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nЭлементы в обратном порядке (игнорируя отрицательные):");
        for (int i = numElements - 1; i >= 0; i--)
        {
            if (array[i] >= 0)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}