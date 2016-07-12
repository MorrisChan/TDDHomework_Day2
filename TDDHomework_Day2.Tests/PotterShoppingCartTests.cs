using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDHomework_Day2.Tests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void Buy_a_Harry_Potter_Episode_1_TotalAmount_should_be_100()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            var expected = 100;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
