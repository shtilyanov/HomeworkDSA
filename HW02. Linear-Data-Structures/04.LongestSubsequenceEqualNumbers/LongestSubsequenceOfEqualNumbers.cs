namespace _04.LongestSubsequenceEqualNumbers
{
    using System.Collections.Generic;

    public class LongestSubsequenceOfEqualNumbers
    {
        public List<int> SubsequenceOfEqualNumbers(List<int> sequence)
        {
            var resultSequence = new List<int>();

            if (sequence.Count > 0)
            {
                int maximumNumber = sequence[0];
                var number = sequence[0];
                var count = 1;
                int maxCount = 1;

                for (int i = 1; i < sequence.Count; i++)
                {
                    if (number == sequence[i])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maximumNumber = number;
                        }

                        count = 1;
                        number = sequence[i];
                    }

                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maximumNumber = number;
                }

                for (int i = 0; i < maxCount; i++)
                {
                    resultSequence.Add(maximumNumber);
                }
            }

            return resultSequence;
        }
    }
}
