namespace Rabbits
{
    using System;
    using System.Collections.Generic;

    class Task2
    {
        static void Main()
        {
            var differentColorRabbits=new Dictionary<int,int>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var count = int.Parse(Console.ReadLine());

                if (differentColorRabbits.ContainsKey(count))
                {
                    differentColorRabbits[count]++;
                }
                else
                {
                    differentColorRabbits.Add(count,1);
                }
            }

            var result = 0;

            foreach (KeyValuePair<int,int> rabbit in differentColorRabbits)
            {
                if (rabbit.Key>=rabbit.Value+1)
                {
                    result += (rabbit.Key+1);
                }
                else
                {
                    var differentRabbits = rabbit.Key;
                    var differentColor = rabbit.Value;

                    while (differentColor>0)
                    {
                        result += (differentRabbits + 1);
                        differentColor -= (differentRabbits + 1);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
