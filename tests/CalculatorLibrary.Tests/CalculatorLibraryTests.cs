using System;
using Xunit;
using CalculatorLibrary;

namespace Calculator.Test
{
    public class CalculatorLibraryTests
    {
        [Fact]
        public void ShouldBeSum()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 + arg2, calculator.DoOperation(arg1, arg2, "a"));
        }
        [Fact]
        public void ShouldBeSubtract()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 - arg2, calculator.DoOperation(arg1, arg2, "s"));
        }
        [Fact]
        public void ShouldBeMultiply()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double arg1 = 3.5;
            double arg2 = 2.5;
            Assert.Equal(arg1 * arg2, calculator.DoOperation(arg1, arg2, "m"));
        }
        [Fact]
        public void ShouldBeDivise()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double arg1 = 4;
            double arg2 = 2;
            Assert.Equal(arg1 / arg2, calculator.DoOperation(arg1, arg2, "d"));
        }
        [Fact]
        public void ShouldBeNAN()
        {
            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            double arg1 = 4;
            double arg2 = 2;
            Assert.Equal(double.NaN, calculator.DoOperation(arg1, arg2, ""));
        }
    }
}
