using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyForTasks.Tests
{
    [TestClass]
    public class MyForTests
    {
        [TestMethod]
        public void For9_4and9_13returned()
        {
            // arrange
            int x = 4;
            int y = 9;
            int expected = 13;

            // act
            MyTasks t = new MyTasks();
            int actual = t.For9(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void For13_19_2returned()
        {
            // arrange
            decimal x = 19M;
            decimal expected = 2M;

            // act
            MyTasks t = new MyTasks();
            decimal actual = t.For13(x);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void For21_2_TwoAndHalfreturned()
        {
            // arrange
            int x = 2;
            double expected = 2.5;

            // act
            MyTasks t = new MyTasks();
            double actual = t.For21(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
