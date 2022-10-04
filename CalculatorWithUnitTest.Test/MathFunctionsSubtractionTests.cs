namespace CalculatorWithUnitTest.Test
{
    public class MathFunctionsSubtractionTests
    {
        [Fact]
        public void SubtractionTwoNumsTest()
        {
            var result = MathFunctions.Subtraction(10, 5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SubtractionTwoNumsWithLastNumAsNegative()
        {
            var result = MathFunctions.Subtraction(10, -5);
            Assert.Equal(15, result);
        }

        [Fact]
        public void SubtractionTwoNumsWithFirstNumAsNegative()
        {
            var result = MathFunctions.Subtraction(-5, 10);
            Assert.Equal(-15, result);
        }

        [Fact]
        public void SubtractionTwoNumsWithBothNumAsNegative()
        {
            var result = MathFunctions.Subtraction(-20, -20);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SubtractionMultiNumsTest()
        {
            var result = MathFunctions.Subtraction(new double[] { 20, 5, 5 });
            Assert.Equal(10, result);
        }

        [Fact]
        public void SubtractionMultiNumsWithOneNegative()
        {
            var result = MathFunctions.Subtraction(new double[] { 20, -5, 5 });
            Assert.Equal(20, result);
        }

        [Fact]
        public void SubtractionMultiNumsWithFirstNegative()
        {
            var result = MathFunctions.Subtraction(new double[] { -20, 5, 5 });
            Assert.Equal(-30, result);
        }

        [Fact]
        public void SubtractionMultiNumsWithLastNegative()
        {
            var result = MathFunctions.Subtraction(new double[] { 20, 5, -5 });
            Assert.Equal(20, result);
        }

        [Fact]
        public void SubtractionMultiNumsWithAllNegative()
        {
            var result = MathFunctions.Subtraction(new double[] { -20, -5, -5 });
            Assert.Equal(-10, result);
        }
    }
}
