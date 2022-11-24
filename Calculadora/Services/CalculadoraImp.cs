namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}
