using System.Collections.Generic;

namespace PascalTriangle
{
    public static class Kata
    {
        public static List<int> PascalsTriangle(int n)
        {
            if (n == 0)
                return null;

            return RecursiveGetPT(n);
        }

        private static List<int> RecursiveGetPT(int n)
        {
            if (n == 1)
            {
                return new List<int>() { 1 };
            }
            else
            {
                var list = RecursiveGetPT(n - 1);
                var newList = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        newList.Add(1);
                    }
                    else
                    {
                        newList.Add(list[list.Count - n + i] + list[list.Count - n + i + 1]);
                    }
                }

                list.AddRange(newList);
                return list;
            }
        }
    }
}