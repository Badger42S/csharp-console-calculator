using System;
using Xunit;
using CalculatorMainProgram;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace CalculatorProgramTest
{
    public class CalculatorTest
    {
        [Fact]
        public void ShouldBeReturnRealResult()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            var outputPoint = new StringWriter();
            Console.SetOut(outputPoint);

            string[] inputStringArray = new[] {"4", "6", "a", "n" };
            var inputString = string.Join("\r\n", inputStringArray);
            var inputPoint = new StringReader(inputString);
            Console.SetIn(inputPoint);

            MainProgram.Main(new string[0]);
            var expectedOutput = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 10" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput, Regex.Replace(outputPoint.ToString(), @"[\r\t\n]+", string.Empty));
        }
        [Fact]
        public void ShouldBeMadeInputCheck()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            var outputPoint = new StringWriter();
            Console.SetOut(outputPoint);

            string[] inputStringArray = new[] {"a", "4", "a", "6", "a", "n" };
            var inputString = string.Join("\r\n", inputStringArray);
            var inputPoint = new StringReader(inputString);
            Console.SetIn(inputPoint);

            MainProgram.Main(new string[0]);
            var expectedOutput = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Type another number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 10" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput, Regex.Replace(outputPoint.ToString(), @"[\r\t\n]+", string.Empty));
        }
        [Fact]
        public void ShouldBeReturnMathError()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            var outputPoint = new StringWriter();
            Console.SetOut(outputPoint);

            string[] inputStringArray = new[] { "4", "0", "d", "n" };
            var inputString = string.Join("\r\n", inputStringArray);
            var inputPoint = new StringReader(inputString);
            Console.SetIn(inputPoint);

            MainProgram.Main(new string[0]);
            var expectedOutput = "Oh no! An exception occurred trying to do the math";

            Assert.True(Regex.IsMatch(outputPoint.ToString(), expectedOutput));
        }
    }

}
