namespace BatataQuente.Tests
{
    public class BatataQuenteTests
    {
        //MetodoTestado_CenarioEsperado_CenarioTestado
        [Fact]
        public void Play_DeveRetornarFilaComUmJogadorAMenos_QuandoChamado()
        {
            //Arrange
            BatataQuente _sut = new BatataQuente();
            var numeroJogadores = 10;

            //Act
            var resultado = _sut.Play(10);
            var contagemResultado = resultado.Count;

            //Assert
            Assert.Equal(contagemResultado, numeroJogadores - 1);
        }

        [Theory]
        [InlineData(10, "6")]
        [InlineData(5, "1")]
        [InlineData(15, "1")]
        [InlineData(100, "16")]
        public void Play_DeveRetornarFilaSemOPerdedor_QuandoChamado(int numeroJogadores, string perdedor)
        {
            //Arrange
            BatataQuente _sut = new BatataQuente();

            //Act
            var resultado = _sut.Play(numeroJogadores);

            //Arrange
            Assert.DoesNotContain(perdedor, resultado);
        }
    }
}