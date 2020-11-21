using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Whole numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16; // same as int16
            int wholeNumber = 32; // int32
            long largeWholeNumber = 64; //int64

            // Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.5454658; //double is default format, you can add a 'd' suffix if desired
            decimal decimalExample = 1.2545648689764546m; // most accurate, most memory

            char letter = 'J'; //single quotes means it has to compile down to a single character

            // Operators

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; //modulos
            Console.WriteLine(remainder);

            Console.WriteLine("hello");

        }

        [TestMethod]

        public void ReferenceTypes()
        {

            // Strings
            string stringExample = "This is a string.";
            string name = "Kendra";

            string declared;
            declared = "Now it's initialized.";

            // Formstting strings
            string concatenate = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}";

            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            // Other object examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            // Collections
            // Arrays

            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" }; // declare an array with square brackets
            string[] students = new string[15]; //limit 'students' array to 15 students

            Console.WriteLine(stringArray);

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence"); //add as many items as you want, arrays have a predetermined quantity of objects

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            // Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            // Other collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>(); //stacked plates metaphor
            
        }
    }
}
