namespace CalculatorWithUnitTest.Test
{
    public class MathFunctionsMultiplyTests
    {
        [Fact]
        public void MultiplicationBothNumsPositive()
        {
            var result = MathFunctions.Multiply(5, 5);
            Assert.Equal(25, result);
        }

        [Fact]
        public void MultiplyFirstNumNegative()
        {
            var result = MathFunctions.Multiply(-5, 5);
            Assert.Equal(-25, result);
        }

        [Fact]
        public void MultiplyLastNumNegative()
        {
            var result = MathFunctions.Multiply(5, -5);
            Assert.Equal(-25, result);
        }

        [Fact]
        public void MultiplyBothNumsNegative()
        {
            var result = MathFunctions.Multiply(-5, -5);
            Assert.Equal(25, result);
        }
    }
}
