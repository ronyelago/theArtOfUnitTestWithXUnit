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

        [Fact]
        public void VeiculoFrear()
        {
            //arrange
            var veiculo = new Veiculo();

            //act
            veiculo.Frear(2);

            Assert.Equal(-30, veiculo.VelocidadeAtual);
        }
    }
}