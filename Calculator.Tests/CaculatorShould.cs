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
        int result = calculator.Divide(a, b);

        // Assert
        Assert.Equal(2, result);
    }
    }
}