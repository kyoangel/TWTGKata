using System.Linq;

namespace ReverseWord
{
    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            var array = str.Split(' ').Select(x => new string(x.Reverse().ToArray())).ToArray();
            return string.Join(" ", array);
        }
    }
}