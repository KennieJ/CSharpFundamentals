using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //Input
        //What we do
        //Output

        //Access Modifier   Return Type     Method signature (name and list of parameters)

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int m, int n)
        {
            int quot = m / n;
            return quot;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        {
            int sum = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 42);

            Assert.AreEqual(19, sum); //run will fail if false

            int product = MultiplyTwoNumbers(8, 5);
            Assert.AreEqual(40, product);
        }
    }
}
