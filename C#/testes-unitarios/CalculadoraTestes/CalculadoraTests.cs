using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveExecutarSoma()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);   
    }

    [Fact]
    public void VerificarNumeroPar()
    {
        // Arrange
        num = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8, 10})]
    public void DeveVerificarPares(int[] numeros)
    {
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}