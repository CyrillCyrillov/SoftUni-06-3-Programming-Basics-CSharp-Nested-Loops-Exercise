using System;

namespace Task04_Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            string nextTheme = " ";
            int numbersOfJudjs = int.Parse(Console.ReadLine());
            
            int count = 0;
            double globalSum = 0;
            while (true)
            {
                nextTheme = Console.ReadLine();
                if (nextTheme == "Finish") break;
                double helpSum = 0;
                for (int i = 1; i <= numbersOfJudjs; i++)
                {
                    double nextEvaluation = double.Parse(Console.ReadLine());
                    helpSum += nextEvaluation;
                }
                Console.WriteLine($"{nextTheme} - {(helpSum / numbersOfJudjs):F2}.");
                count += 1;
                globalSum += (helpSum / numbersOfJudjs);
            }
            Console.WriteLine($"Student's final assessment is {(globalSum / count):F2}.");
        }
    }
}
