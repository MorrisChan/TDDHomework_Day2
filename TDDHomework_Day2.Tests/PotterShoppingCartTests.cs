using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDHomework_Day2.Tests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_TotalAmount_should_be_100()
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

        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_2_TotalAmount_should_be_190()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            target.Add("episode2", 1);
            double expected = 190;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_2_3_TotalAmount_should_be_270()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            target.Add("episode2", 1);
            target.Add("episode3", 1);
            double expected = 270;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_2_3_4_TotalAmount_should_be_320()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            target.Add("episode2", 1);
            target.Add("episode3", 1);
            target.Add("episode4", 1);
            double expected = 320;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_2_3_4_5_TotalAmount_should_be_375()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            target.Add("episode2", 1);
            target.Add("episode3", 1);
            target.Add("episode4", 1);
            target.Add("episode5", 1);
            double expected = 375;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Harry_Potter_Episode_1_2_and_2_Episode3_TotalAmount_should_be_370()
        {
            //arrange
            var target = new PotterShoppingCart();
            target.Add("episode1", 1);
            target.Add("episode2", 1);
            target.Add("episode3", 2);
            double expected = 370;
            //actual
            var actual = target.CalculateTotalAmount();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
