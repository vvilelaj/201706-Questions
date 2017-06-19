using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Questions
{
    /*
	Your quirky boss collects rare, old coins...
	They found out you're a programmer and asked you to solve something they've been wondering for a long time.

	Write a function that, given:

	an amount of money
	an array of coin denominations
	computes the number of ways to make the amount of money with coins of the available denominations.

	Example: for amount=4 (4¢) and denominations=[1,2,3,4] (1¢, 2¢ and 3¢), 
	your program would output 44—the number of ways to make 44¢ with those denominations:

	1¢, 1¢, 1¢, 1¢
	1¢, 1¢, 2¢
	1¢, 3¢
	2¢, 2¢
	*/
    public class _03_Coins
    {
        public List<List<int>> NumberOfWays(int amount, int[] denominations)
        {
            List<List<int>> numberOfWays = new List<List<int>>();

            if (amount <= 0)
                return numberOfWays;

            if (denominations == null || denominations.Count() == 0)
                return numberOfWays;

            throw new NotImplementedException();
        }

        public List<List<int>> PossiblyDenominations(int[] denomination)
        {
            var possiblyDenominatios = new List<List<int>>();
            if (denomination.Length <= 1)
            {
                possiblyDenominatios.Add(denomination.ToList());
            }



            throw new NotImplementedException();
        }
    }

    public class Change
    {
        //private Dictionary<string, int> _memo = new Dictionary<string, int>();

        public int ChangePossibilitiesTopDown(int amountLeft, int[] denominations, int currentIndex = 0)
        {
            // Base cases:
            // We hit the amount spot on. Yes!
            if (amountLeft == 0)
            {
                return 1;
            }

            // We overshot the amount left (used too many coins)
            if (amountLeft < 0)
            {
                return 0;
            }

            // We're out of denominations
            if (currentIndex == denominations.Length)
            {
                return 0;
            }

            // Print out actual part of array
            Console.Write($"checking ways to make {amountLeft} with ");
            Console.WriteLine($"[{string.Join(", ", denominations.Skip(currentIndex).Take(denominations.Length - currentIndex))}]");

            // Choose a current coin
            int currentCoin = denominations[currentIndex];

            // See how many possibilities we can get
            // for each number of times to use currentCoin
            int numPossibilities = 0;
            while (amountLeft >= 0)
            {
                numPossibilities += ChangePossibilitiesTopDown(amountLeft, denominations, currentIndex + 1);
                amountLeft -= currentCoin;
            }

            return numPossibilities;
        }
    }
}
