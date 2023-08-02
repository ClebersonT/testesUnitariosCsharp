using Calculadora.services;
namespace CalculadoraTestes;

public class UnitTestCalculadora
{

    private CalculadoraImp _calc;

    public UnitTestCalculadora(){
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void TestSomar()
    {
        //Arrenge - preparação do cenário de teste, parametros e etc
        int num1 = 5;
        int num2 = 10;

        //Act - ação
        int resultado =  _calc.Somar(num1, num2);

        //Assert - resultado esperado
        Assert.Equal(15, resultado);
    }
}