using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E4.Test2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckEmptyString()
        {
            var number = Calculator.Add("");

            Assert.AreEqual(number, "0");
        }

        [TestMethod]
        public void CheckDelimitedComma()
        {
            var number = Calculator.Add("1,2,25,45,787");

            Assert.AreEqual(number, "860");
        }

        [TestMethod]
        public void CheckDelimitedNextLine()
        {
            var number = Calculator.Add(@"1\n2,3");

            Assert.AreEqual(number, "6");
        }

        [TestMethod]
        public void CheckChangeDelimiter()
        {
            var number = Calculator.Add(@"//;\n1;2");

            Assert.AreEqual(number, "3");
        }

        [TestMethod]
        public void CheckNegativeNumber()
        {
            var number = Calculator.Add(@"//;\n1;-2;-10");

            Assert.AreEqual(number, "-2,-10");
        }
    }
}
