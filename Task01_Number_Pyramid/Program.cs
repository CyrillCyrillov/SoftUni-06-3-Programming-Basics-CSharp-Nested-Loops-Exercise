using System;

namespace Task01_Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countPrint = 1;
            int contForNewLine = 0;
            for (int i = 1; i <= n; i++)
            {
                while (contForNewLine != i)
                {
                    if (countPrint == n+1) break;
                    Console.Write($"{countPrint} ");
                    countPrint += 1;
                    contForNewLine += 1;
                    if (contForNewLine == i) break;
                }
                contForNewLine = 0;
                Console.WriteLine();
            }
        }
    }
}
