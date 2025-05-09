using MyProjects;

namespace TestUnit
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            string data = "23/04/2025";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        //SOMAR
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculadora = calc.Somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        //SUBTRAIR
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculadora = calc.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        //MULTIPLICAR
        [Theory]
        [InlineData(2, 6, 12)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculadora = calc.Multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        //Dividir
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse();
            int resultadoCalculadora = calc.Dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}