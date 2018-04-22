namespace CountingChangeCombinations
{
    public class Kata
    {
        private static int[] _coins;

        public static int CountCombinations(int money, int[] coins)
        {
            _coins = coins;
            var counts = FindCombination(money, 0);
            return counts;
        }

        private static int FindCombination(int money, int index)
        {
            if (MatchAmount(money))
            {
                return 1;
            }
            else if (OverAmountOrNoNextCoin(money, index))
            {
                return 0;
            }

            var takeCurrent = FindCombination(money - _coins[index], index);
            var takeNext = FindCombination(money, index + 1);
            return takeCurrent + takeNext;
        }

        private static bool MatchAmount(int money)
        {
            return money == 0;
        }

        private static bool OverAmountOrNoNextCoin(int money, int index)
        {
            return money < 0 || index == _coins.Length;
        }
    }
}