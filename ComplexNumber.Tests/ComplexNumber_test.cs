using Xunit;
using ComplexNumber;

namespace ComplexNumber.UnitTests
{
    public class ComplexNumber_Tests
    {

        [Fact]
        public void ComplexToString()
        {
            ComplexNumber complex = new ComplexNumber(1, 2);
            var result = complex.ToString();
            Assert.Equal("1 + 2i", result);
        }

        [Fact]
        public void ComplexAddition()
        {
            ComplexNumber a = new ComplexNumber(1, 2);
            ComplexNumber b = new ComplexNumber(1, 2);
            ComplexNumber result = a + b;
            Assert.Equal(2, result.real);
            Assert.Equal(4, result.imaginary);
        }

        [Fact]
        public void ComplexAdditionWithNegatives()
        {
            ComplexNumber a = new ComplexNumber(-1, 2);
            ComplexNumber b = new ComplexNumber(1, -2);
            ComplexNumber result = a + b;
            Assert.Equal(0, result.real);
            Assert.Equal(0, result.imaginary);
        }
    }
}