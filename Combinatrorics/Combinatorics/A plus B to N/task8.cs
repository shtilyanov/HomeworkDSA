namespace A_plus_B_to_N
{
    using System;
    using System.Collections.Generic;

    public class task8
    {
        public static List<long> coeficents = new List<long>();

        public static void GetCoeficents(int n)
        {
            long c = 1;
            coeficents.Add(c);
            for (int i = 0; i < n; i++)
            {
                c = c * (n - i) / (i + 1);
                coeficents.Add(c);
            }

        }

        public static void PrintResult(int n, char a, char b)
        {
            Console.Write("({0}^{1})+", a, n);

            for (int i = 1; i < n; i++)
            {
                Console.Write("{0}({1}^{2})({3}^{4})+", coeficents[i], a, n - i, b, i);
            }

            Console.Write("({0}^{1})", b, n);
            Console.WriteLine();
        }

        static void Main()
        {
            string input = Console.ReadLine();
            char a = input[1];
            char b = input[3];
            Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            GetCoeficents(n);
            PrintResult(n, a, b);
        }
    }
}
