using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyComponentLib;

namespace MyComponentsLib.Tests
{
    [TestClass]
    public class MathComponentTest
    {
        [TestMethod]
        public void Test_For_Adding_Number()
        {
            var component = new MathComponent();
            var expected = 22;
            var input1 = 12;
            var input2 = 10;
            var actual = component.AddNumbers(input1,input2);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Test_For_Adding_NegativeNumbers()
        {
            var component = new MathComponent();
            var expected = -25;
            var input1 = -15;
            var input2 = -10;
            var actual = component.AddNumbers(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_For_Adding_Numbers_In_Array()
        {
            var component = new MathComponent();
            var expected = 9;
            var input = new int[] { 2, 3, 4};
            var actual = component.AddNumbers(input);
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
