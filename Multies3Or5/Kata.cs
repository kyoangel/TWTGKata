using System.Collections.Generic;
using System.Linq;

namespace Multies3Or5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            // Magic Happens
            var ints = new List<int>();
            for (int i = 3; i < value; i++)
            {
                ints.Add(i);
            }

            return ints.Where(x => (x % 3 == 0) || (x % 5 == 0)).Sum();
        }
    }
}