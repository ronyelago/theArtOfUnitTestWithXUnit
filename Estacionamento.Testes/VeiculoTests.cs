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

        [Fact]
        public void TipoVeiculo_NaoDefinido_DeveRetornarAutomovel()
        {
            //arrange
            var veiculo = new Veiculo();
            //act & assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
        }

        [Fact]
        public void AlterarDadosVeiculo()
        {
            var veiculo = new Veiculo();

            
        }
    }
}