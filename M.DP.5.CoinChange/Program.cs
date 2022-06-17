using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.DP._5.CoinChange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Input: coins = [1,2,5], amount = 11
                Output: 3
                Explanation: 11 = 5 + 5 + 1
            */
            int[] coins = { 1, 2, 5 };
            int amount = 11;
            //int[] coins = { 2 };
            //int amount = 3;
            int res = CoinChange(coins, amount);

        }

        public static int CoinChange(int[] coins, int amount)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            return changeHelper(coins, amount, memo);
        }

        public static int changeHelper(int[] coins, int remainingAmount,  Dictionary<int, int> memo)
        {
            //base case for success 0 and stop for -ve
            if (remainingAmount == 0)
                return 0;

            if (memo.ContainsKey(remainingAmount))
                return memo[remainingAmount];

            int minCoin = int.MaxValue;
            //logic for each possibility find min return
            foreach (int coin in coins)
            {
                if (coin <= remainingAmount)
                {
                    int min = changeHelper(coins, remainingAmount - coin, memo);
                    if (min < 0)
                        continue;
                    else
                        minCoin = Math.Min(minCoin, min);
                }
            }

            memo[remainingAmount] = minCoin == int.MaxValue ? -1 : minCoin + 1;
            return memo[remainingAmount];

        }

    }
}
