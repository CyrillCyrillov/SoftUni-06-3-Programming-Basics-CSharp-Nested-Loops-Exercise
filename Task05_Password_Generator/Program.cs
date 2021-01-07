using System;

namespace Task05_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string helpAlphavit = "abcdefghij";
            //string passWord = " ";
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int first = 1; first < n; first++)
            {
                for (int second = 1; second < n; second++)
                {
                    for (int third = 0; third <l; third++)
                    {
                        for (int fourth = 0; fourth <l; fourth++)
                        {
                            for (int fifth = 0; fifth <= n; fifth++)
                            {
                                if (fifth > first && fifth > second)
                                {
                                    // passWord = first.ToString() + second.ToString() + [third].helpAlphavit + [fourth].helpAlphavit + fifth.ToString();
                                    // Console.Write($"{passWord} ");
                                    Console.Write($"{first}{second}{helpAlphavit[third]}{helpAlphavit[fourth]}{fifth} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
