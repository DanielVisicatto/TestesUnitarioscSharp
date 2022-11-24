//Preciso ligar esse projeto no nosso projeto oficial,então usamos uma referencia
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {
        private CalculadoraImp _calc;

        public CalculadoraTestes()
        {
            _calc = new CalculadoraImp();
        }

        [Fact]
        public void DeveSomar5Com10ERetornar15() // descrever o melhor possivel o que ele testa
        {
            // Arrange
            int x = 5, y = 10;

            // Act
            int resultado = _calc.Somar(x, y);

            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void DeveSomar10Com10ERetornar20()
        {
            // Arrange
            int x = 10, y = 10;

            // Act
            int resultado = _calc.Somar(x,y);

            // Assert
            Assert.Equal(20, resultado);
        }

        [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
        {
            // Arrange
            int num = 4;

            //Act
            bool resultado = _calc.EhPar(num);

            // Assert
            Assert.True(resultado);
        }

        //2, 4, 6, 8, 10 testando se é par ao mesm tempo usamos essa [Theory] -> [InlineData(n)]
        //[Theory]
        //[InlineData(2)]
        //[InlineData(4)]
        //[InlineData(6)] vou fazer com que receba um array de int
        //[InlineData(8)]
        //[InlineData(10)]
        [Theory]
        [InlineData(new int[] { 2, 4 })]
        [InlineData(new int[] { 6, 8, 10 })]
        public void DeveRetornarVerdadeiroSeOsNumerosForemPares(int[] nums)
        {
            //Arrange Não precisa
            //Act /Assert Juntos                       
            Assert.All(nums, x => Assert.True(_calc.EhPar(x)));
        }
    }
}