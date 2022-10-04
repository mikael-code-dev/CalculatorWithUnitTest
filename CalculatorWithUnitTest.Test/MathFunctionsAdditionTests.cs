namespace CalculatorWithUnitTest.Test
{
    public class MathFunctionsAdditionTests
    {
        [Fact]
        public void AdditionTwoNumsTest()
        {
            var result = MathFunctions.Addition(5, 5);
            Assert.Equal(10, result);
        }

        [Fact]
        public void AdditionTwoNumsWithNegativeNum1()
        {
            var result = MathFunctions.Addition(-5, 5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void AdditionTwoNumsWithNegativeNum2()
        {
            var result = MathFunctions.Addition(10, -5);
            Assert.Equal(5, result);
        }

        [Fact]
        public void AdditionTwoNumsWithTwoNegativeNums()
        {
            var result = MathFunctions.Addition(-10, -10);
            Assert.Equal(-20, result);
        }

        [Fact]
        public void AdditionMultiNumsTest()
        {
            var result = MathFunctions.Addition(new double[] { 5, 5, 5 });
            Assert.Equal(15, result);
        }

        [Fact]
        public void AdditionMultiNumsWithOneNegativNumTest()
        {
            var result = MathFunctions.Addition(new double[] { 5, -5, 5 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void AdditionMultiNumsWithOneNegativeNumAsStartNum()
        {
            var result = MathFunctions.Addition(new double[] { -5, 5, 5 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void AdditionMultiNumsWithOneNegativeNumAsLastNum()
        {
            var result = MathFunctions.Addition(new double[] { 5, 5, -5 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void AdditionMultiNumsWithAllNumsNegative()
        {
            var result = MathFunctions.Addition(new double[] { -5, -5, -5 });
            Assert.Equal(-15, result);
        }
    }
}