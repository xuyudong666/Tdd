using Moq;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Calculate_WhenCalled_ReturnsNumber()
    {
        var num1 = It.IsAny<int>();
        var num2 = It.IsAny<int>();
        var res = It.IsAny<int>();
        Mock<ICalculator> calculatorMock = new();
        calculatorMock.Setup(c => c.Calculate(num1, num2)).Returns(res);

        var result = calculatorMock.Object.Calculate(num1, num2);

        Assert.Equal(res, result);
    }
}