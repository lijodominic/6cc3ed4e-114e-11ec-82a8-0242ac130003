using System.Collections.Generic;
using System.Linq;

namespace IncrementSequenceApi.Service
{
    public static class IncrementSequenceService
    {
        public static char[] DemilimerChars = { ',', ' ', ';' };
        public static string InvalidInput = "Invalid Input";
        public static string GetIncreasingSequence(string numberStr)
        {
            var numberStrLists = numberStr.Split(DemilimerChars).ToList();
            var numberIntLists = new List<int>();
            var longestSequence = new List<int>();

            if (numberStrLists.Any() && numberStrLists.All(s => int.TryParse(s, out int val)))
            {
                numberIntLists = numberStrLists.Select(s => int.Parse(s)).ToList();
                var currentSequence = new List<int>();
                foreach (var item in numberIntLists)
                {
                    if (currentSequence.Count == 0 || item - currentSequence.Last() > 1)
                    {
                        currentSequence.Add(item);
                    }
                    else
                    {
                        if (currentSequence.Count() > longestSequence.Count())
                        {
                            longestSequence.Clear();
                            longestSequence.AddRange(currentSequence);
                        }
                        currentSequence.Clear();
                        currentSequence.Add(item);
                    }
                }

                // replace if we found longest sequence
                if (currentSequence.Count() > longestSequence.Count())
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(currentSequence);
                }


            }

            return longestSequence.Any() ? string.Join(" ", longestSequence.Select(c => c)) : InvalidInput;
        }
    }
}
