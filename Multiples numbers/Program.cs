using System;

namespace Multiples_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minMultiple = 50;
            int maxMultiple = 150;
            int numberOfMultiples = 0;
            int minRandomValue = 10;
            int maxRandomValue = 26;
            int randomValue = random.Next(minRandomValue, maxRandomValue);

            Console.WriteLine("Дано случайное число: " + randomValue);

            for (int i = 0; i <= maxMultiple; i++)
            {
                i += randomValue;

                if (i >= minMultiple)
                {
                    numberOfMultiples++;
                }
            }

            Console.WriteLine($"Количество чисел от {minMultiple} до {maxMultiple}, которые кратыны {randomValue}: {numberOfMultiples} ");
        }
    }
}
