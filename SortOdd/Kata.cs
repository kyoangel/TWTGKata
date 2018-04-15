namespace SortOdd
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (IsEven(array, i))
                    continue;
                for (var j = 0; j < array.Length; j++)
                {
                    if (IsEven(array, j))
                        continue;
                    if (array[i] >= array[j]) continue;
                    var temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }

            return array;
        }

        private static bool IsEven(int[] array, int i)
        {
            return array[i] % 2 == 0;
        }
    }
}