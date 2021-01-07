using System;

namespace Task02_Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;

                string curentNumber = i.ToString();
                for (int j = 0; j < curentNumber.Length; j++)
                {
                    int curentDigit = int.Parse(curentNumber[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += curentDigit;
                    }
                    else
                    {
                        oddSum += curentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
