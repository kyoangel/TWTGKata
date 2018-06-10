using System.Linq;

namespace HighestRankNumber
{
    public class Kata
    {
        public static int HighestRank(int[] arr)
        {
            return arr.Any()
                ? arr.GroupBy(x => x).OrderBy(g => g.Count()).ThenBy(c => c.Key).ToList().Last().Key
                : 0;
        }
    }
}