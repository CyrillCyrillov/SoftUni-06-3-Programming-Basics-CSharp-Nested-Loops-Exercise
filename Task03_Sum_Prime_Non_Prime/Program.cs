using System;

namespace Task03_Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;
            string nextNumber = " ";
            int check = 0;

            
            while (true)
            {
                nextNumber = (Console.ReadLine());
                if (nextNumber == "stop") break;
                int nextNumberDigit = int.Parse(nextNumber);
                if (nextNumberDigit < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else 
                {
                    check = 0;
                    for (int i = 2; i < (nextNumberDigit / 2); i++)
                    {
                        if (nextNumberDigit % i == 0)
                        {
                            sumNonPrime += nextNumberDigit;
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        sumPrime += nextNumberDigit;
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
