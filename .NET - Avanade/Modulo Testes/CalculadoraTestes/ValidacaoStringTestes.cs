public class ValidacaoStringTestes
{
    private ValidacaoString _valida;

    public ValidacaoStringTestes()
    {
        _valida = new();
    }

    [Fact]
    public void DeveContar3CaracteresEmOlaRetorna3() { 
        //Arrange
        string texto = "Ola";
        //Act
        var resultado = _valida.ContaCaracteres(texto);
        //Assert
        Assert.Equal(3,resultado);
    }
}
