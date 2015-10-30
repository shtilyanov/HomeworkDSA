namespace _01.SumAndAverageOfTheElementsOfTheSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static int Sum(List<int> sequence)
        {
            var sum = 0;

            foreach (var number in sequence)
            {
                sum += number;
            }

            return sum;
        }

        public static double Average(List<int> sequence)
        {
            double average = 0;

            average = (double)Sum(sequence)/sequence.Count;

            return average;
        }

        static void Main()
        {
            var sequence = new List<int>();

            while (true)
            {
                var inputNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(inputNumber))
                {
                    break;
                }
                else if (int.Parse(inputNumber)<0)
                {
                    throw new ArgumentException("Invalid input argument");
                }
                else 
                {
                    sequence.Add(int.Parse(inputNumber));
                }               
            }

            Console.WriteLine(Sum(sequence));
            Console.WriteLine((double)Average(sequence));
        }
    }
}
