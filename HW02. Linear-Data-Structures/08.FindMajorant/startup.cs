namespace _08.FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {


        static void FindMajorantNumber(List<int> sequence)
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

            var maxOccurence = occurenceOfNumbers.Values.Max();
            var keyForMaxOccurence = occurenceOfNumbers.FirstOrDefault(d => d.Value == maxOccurence);

            if (maxOccurence > sequence.Count / 2)
            {
                Console.WriteLine("Majorant is {0} it occurs {1} times", keyForMaxOccurence.Key, maxOccurence);
            }
            else
            {
                Console.WriteLine("Majorant doesn't exist");
            }
        }

        static void Main()
        {
            var sequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var sequence2 = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
          
            FindMajorantNumber(sequence);
            FindMajorantNumber(sequence2);
        }
    }
}
