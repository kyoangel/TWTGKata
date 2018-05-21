using System.Linq;

namespace ReverseWord
{
    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Select(x => new string(x.Reverse().ToArray())));
        }
    }
}