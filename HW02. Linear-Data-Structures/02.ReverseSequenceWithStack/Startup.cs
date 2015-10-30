namespace _02.ReverseSequenceWithStack
{
    using System;
    using System.Collections;

    public class Startup
    {
        static void Main()
        {
            Console.WriteLine("Enter the count of numbers in the sequence");

            int countOfNumbers=int.Parse(Console.ReadLine());

            var numbersToReverse=new Stack();

            for(int i=0;i<countOfNumbers;i++)
            {
                var inputNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(inputNumber))
                {
                    break;
                }
                else
                {
                    numbersToReverse.Push(int.Parse(inputNumber));
                }
            }

            while (numbersToReverse.Count>0)
            {
                Console.WriteLine(numbersToReverse.Pop());
            }
        }
    }
}
