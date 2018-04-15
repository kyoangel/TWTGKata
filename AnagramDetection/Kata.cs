using System.Linq;

namespace AnagramDetection
{
    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            var ori = original.ToLower().ToCharArray().OrderBy(x => x);
            var target = test.ToLower().ToCharArray().OrderBy(x => x);
            return ori.SequenceEqual(target);
        }
    }
}