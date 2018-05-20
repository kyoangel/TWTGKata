using System.Collections.Generic;
using System.Linq;

namespace FindTheMissingTermInAP
{
    public static class Kata
    {
        public static int FindMissing(List<int> list)
        {
            if (!list.Any())
            {
                return 0;
            }
            var sum = (list.First() + list.Last());
            while (list.Count > 1)
            {
                var target = list.First();
                var candidate = sum - target;
                if (list.Contains(candidate))
                {
                    list.Remove(target);
                    list.Remove(candidate);
                }
                else
                {
                    return candidate;
                }

            }
            return sum - list.Single();
        }
    }
}