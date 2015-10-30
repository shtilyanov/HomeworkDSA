namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            var givenSequence = new List<int>() { 0, -1, -15, 4, 6, -2, 33, -22, 0, 41, -16 };

            givenSequence.RemoveAll(c => c < 0);

            foreach (var number in givenSequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
