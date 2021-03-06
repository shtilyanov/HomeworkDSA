﻿namespace Dividers
{
    using System;

    class Task3
    {
        private static int number;
        private static int numberOfDividers=Int32.MaxValue;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            PermuteRep(arr, 0, arr.Length);
            Console.WriteLine(number);
        }

        static void PermuteRep(int[] arr, int start, int n)
        {
           CompareDividers(arr);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

        static void CompareDividers(int[] arr)
        {
            var currentNumber = int.Parse(string.Join("", arr));
            var counter = 0;
            for (int i = 2; i < currentNumber; i++)
            {
                if (currentNumber % i == 0)
                {
                    counter++;
                }
                else
                {
                    continue;
                }
            }

            if (counter < numberOfDividers)
            {
                numberOfDividers = counter;
                number = currentNumber;
            }
        }
    }
}
