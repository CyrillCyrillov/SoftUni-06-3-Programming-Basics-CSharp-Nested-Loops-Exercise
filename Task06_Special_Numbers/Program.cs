using System;
using System.Collections.Specialized;
using System.Threading;

namespace Task06_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int count = 0;
                for (int j = 0; j <= 3; j++)
                {
                    string curentNumber = i.ToString();
                    int curentDigit = int.Parse(curentNumber[j].ToString());
                    if (curentDigit == 0)
                    {
                        break;
                    }
                    if (n % curentDigit == 0)
                    {
                        count += 1; 
                    }
                }
                if (count == 4)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
