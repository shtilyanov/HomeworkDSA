namespace Passwords
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Task1
    {
        static void Main()
        {
            var input=Console.ReadLine();
            var count = input.Count(x => x =='*');
            BigInteger resultCombinations =(BigInteger) Math.Pow(2, count);
            Console.WriteLine(resultCombinations);

        }
    }
}
