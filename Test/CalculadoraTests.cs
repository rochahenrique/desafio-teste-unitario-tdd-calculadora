using Calculadora.Services;

namespace Test;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(7, 9, 16)]
    public void TesteSomar(int num1, int num2, int resultadoEsperado)
    {
        //Arrange

        //Action
        var resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(17, 7, 10)]
    public void TesteSubtrair(int num1, int num2, int resultadoEsperado)
    {
        //Arrange

        //Action
        var resultado = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(11, 0, 0)]
    [InlineData(7, 1, 7)]
    [InlineData(12, 10, 120)]
    public void TesteMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        //Arrange

        //Action
        var resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 0)]
    [InlineData(0, 9, 0)]
    [InlineData(7, 3, 2)]
    [InlineData(100, 2, 50)]
    public void TesteDividir(int num1, int num2, int resultadoEsperado)
    {
        //Arrange

        //Action
        var resultado = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        //Arrange
        _calc.Somar(1, 3);
        _calc.Somar(2, 3);
        _calc.Somar(5, 3);
        _calc.Somar(2, 4);

        //Action
        var lista = _calc.MostrarHistorico();

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
