namespace _06.RemoveNumbersWithOddCountInSequence
{
    using System;
    using System.Collections.Generic;

    class RemoveNumbers
    {
        static void RemoveNumbersWithOddCount(List<int> sequence)
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
                if (number.Value % 2 == 1)
                {
                    sequence.RemoveAll(c => c == number.Key);
                }
            }
        }

        static void Main()
        {
            var sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            RemoveNumbersWithOddCount(sequence);

            foreach (var number in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
