using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int x = 5;
int y = 10;

Console.WriteLine("{0} + {1} = {2}", x, y, c.Somar(x, y));
