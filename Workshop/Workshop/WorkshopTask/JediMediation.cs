namespace WorkshopTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class JediMediation
    {
        public static void Main()
        {
            var numberOfJedi = int.Parse(Console.ReadLine());
            var jediToMediate = Console.ReadLine().Split(' ');
            var listOfMasters = new List<string>();
            var listOfKnights = new List<string>();
            var listOfPaduans = new List<string>();

            for (int i = 0; i < numberOfJedi; i++)
            {
                switch (jediToMediate[i][0])
                {
                    case 'm': listOfMasters.Add(jediToMediate[i]);
                        break;
                    case 'k': listOfKnights.Add(jediToMediate[i]);
                        break;
                    case 'p': listOfPaduans.Add(jediToMediate[i]);
                        break;
                    default: throw new ArgumentException();
                }
            }

            var output = new StringBuilder();

                foreach (var master in listOfMasters)
                {
                    output.Append(master + ' ');
                }

                foreach (var knight in listOfKnights)
                {
                    output.Append(knight + ' ');
                }

                foreach (var paduan in listOfPaduans)
                {
                    output.Append(paduan + ' ');
                }

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
