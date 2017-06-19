using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions.Questions;
using System.Linq;

namespace Questions.UnitTests2.Questions
{
    /// <summary>
    /// Summary description for _03
    /// </summary>
    [TestClass]
    public class _03_CoinsUnitTests
    {
        [TestClass]
        public class NumberOfWays
        {
            [TestMethod]
            public void NumberOfWays_WhenAmountIsZero_ReturnEmptyList()
            {
                var coins = new _03_Coins();

                var result = coins.NumberOfWays(0, null);

                Assert.IsNotNull(result);
                Assert.AreEqual(0, result.Count);
            }

            [TestMethod]
            public void NumberOfWays_WhenAmountIsNoZeroAndDenominationsIsNull_ReturnEmptyList()
            {
                var coins = new _03_Coins();

                var result = coins.NumberOfWays(10, null);

                Assert.IsNotNull(result);
                Assert.AreEqual(0, result.Count);
            }

            [TestMethod]
            public void NumberOfWays_WhenAmountIsNoZeroAndDenominationsIsEmpty_ReturnEmptyList()
            {
                var coins = new _03_Coins();

                var result = coins.NumberOfWays(10, new int[] { });

                Assert.IsNotNull(result);
                Assert.AreEqual(0, result.Count);
            }
        }

        [TestClass]
        public class PossiblyDenominations
        {
            [TestMethod]
            public void PossiblyDenominations_ReceivesOneElements_ReturnsOne() {
                var coins = new _03_Coins();

                var result = (int[])_03_Coins.PossiblyDenominations(new int[] { 1 });

                Assert.AreEqual(1, result.Length);
                Assert.AreEqual(result[0], 1);

            }

            [TestMethod]
            public void PossiblyDenominations_ReceivesTwoElements_ReturnsOne()
            {
                var coins = new _03_Coins();

                var result = _03_Coins.PossiblyDenominations(new int[] { 1, 2 });

                Assert.AreEqual(3, result.Count);
            }
        }

    }
}
