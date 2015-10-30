namespace _07.CountTheNumberOfOccurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void FindNumberOfOccurence(List<int> sequence)
        {
            var occurenceOfNumbers = new Dictionary<int, int>();

            foreach (var number in sequence)
            {
                if (occurenceOfNumbers.ContainsKey(number))
                {
                    occurenceOfNumbers[number]++;
                }
                else
                {
                    occurenceOfNumbers[number] = 1;
                }
            }

            foreach (KeyValuePair<int, int> number in occurenceOfNumbers)
            {
                Console.WriteLine("Number {0} -> {1} times", number.Key, number.Value);
            }
        }

        static void Main()
        {
            var sequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

           FindNumberOfOccurence(sequence);
        }
    }
}
