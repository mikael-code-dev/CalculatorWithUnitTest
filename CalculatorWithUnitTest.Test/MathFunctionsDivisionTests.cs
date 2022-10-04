namespace CalculatorWithUnitTest.Test
{
    public class MathFunctionsDivisionTests
    {
        [Fact]
        public void DivisionBothNumsPositive()
        {
            var result = MathFunctions.Division(10, 2);
            Assert.Equal(5, result);
            Assert.IsType<decimal>(result);
        }

        [Fact]
        public void DivisionLastNumNegative()
        {
            var result = MathFunctions.Division(10, -2);
            Assert.Equal(-5, result);
            Assert.IsType<decimal>(result);
        }

        [Fact]
        public void DivisionFirstNumNegative()
        {
            var result = MathFunctions.Division(-10, 2);
            Assert.Equal(-5, result);
            Assert.IsType<decimal>(result);
        }

        [Fact]
        public void DivisionBothNumsNegative()
        {
            var result = MathFunctions.Division(-10, -2);
            Assert.Equal(5, result);
            Assert.IsType<decimal>(result);
        }

        public void DivisionWithZeroASDenominator()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                var result = MathFunctions.Division(10, 0);
                Assert.IsType<decimal>(result);
            });
        }
    }
}
