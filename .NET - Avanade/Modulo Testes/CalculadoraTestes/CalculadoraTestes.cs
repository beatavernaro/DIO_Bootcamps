using System.Reflection.Metadata;
using Xunit.Sdk;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private Calculadora _calc;
    public CalculadoraTestes(){
        _calc = new Calculadora();
    }

    [Fact]
    public void Somar5com10eRetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        var resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void Subtrair10com5eRetornar5(){
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int resultado = _calc.Subtrair(10,5);

        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Dividir15com3eRetornar5()
    {
        // Given
        int num1 = 15;
        int num2 = 3;
        // When
        var resultado = _calc.Dividir(num1, num2);
    
        // Then
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Multiplicar5com3eRetornar15(){
        //Arrange
        int num1 = 5;
        int num2 = 3;

        //Act
        int resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void VerificaSe2EParERetornaTrue(){
        //Arrange
        int a = 2;
        //Act
        bool resultado = _calc.Par(a);
        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void VerificaSe3EParERetornaFalse(){
        //Arrange
        int a = 3;
        //Act
        bool resultado = _calc.Par(a);

        //Assert
        Assert.False(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8})]
    public void VerificaSeEParERetornaTrue(int[] numero){
       Assert.All(numero, num => Assert.True(_calc.Par(num)));
    }

}