using Estacionamento.Models;
using Xunit;

namespace Estacionamento.Testes
{
    public class VeiculoTests
    {
        [Fact]
        public void VeiculoAcelerar4()
        {
            //arrange
            var veiculo = new Veiculo();
            
            //act
            veiculo.Acelerar(10);
            
            //assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
    }
}