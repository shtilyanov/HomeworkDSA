namespace _03.SortingSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
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
                else
                {
                    sequence.Add(int.Parse(inputNumber));
                }               
            }

            sequence.Sort();

            foreach (var number in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
