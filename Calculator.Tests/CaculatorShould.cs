using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Subtract(a, b);

        // Assert
        Assert.Equal(2, result);
    }

        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var calculator = new Calculator();
            int a = -10;
            int b = -5;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-5, result);
        }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 6;
        int b = 3;

        // Act
        double result = calculator.Divide(a, b);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void IsPrime_NumberLessThan2_ReturnsFalse()
    {
        var calculator = new Calculator();
        Assert.False(calculator.IsPrime(0));
        Assert.False(calculator.IsPrime(1));
    }
    }
}