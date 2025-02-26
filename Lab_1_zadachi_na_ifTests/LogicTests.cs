using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FindTwoSmallestTest()
        {
            var a = 1;
            var b = 2;
            var c = 3;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod()]
        public void FindTwoSmallestTest1()
        {
            var a = 1;
            var b = 3;
            var c = 2;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod()]
        public void FindTwoSmallestTest2()
        {

            var a = 2;
            var b = 1;
            var c = 3;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod()]
        public void FindTwoSmallestTest3()
        {
            var a = 2;
            var b = 3;
            var c = 1;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod()]
        public void FindTwoSmallestTest4()
        {
            var a = 3;
            var b = 1;
            var c = 2;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod()]
        public void FindTwoSmallestTest5()
        {
            var a = 3;
            var b = 2;
            var c = 1;

            var result = Logic.FindTwoSmallest(a, b, c);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod()]
        public void CalculateProductTest6()
        {
            var numbers = new int[] { 1, 2 };

            var result = Logic.CalculateProduct(numbers);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void IsDuplicateTest()
        {
            int number = 1;
            int[] numbers = new int[] { 1 };
            bool result = Logic.IsDuplicate(number, numbers);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void IsNotDuplicateTest()
        {
            int number = 2;
            int[] numbers = new int[] { 1 };
            bool result = Logic.IsDuplicate(number, numbers);
            Assert.AreEqual(false, result);
        }
    }
}