using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacaoStringTestes
    {
        private ValidacaoString _validacao;

        public ValidacaoStringTestes()
        {
            _validacao = new ValidacaoString();
        }

        [Fact]
        public void Contando3CaracteresEmOlaERetornando3()
        {
            // Arrange
            string texto = "Ola";

            // Act
            int resultado = _validacao.ContarCaracteres(texto);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}
