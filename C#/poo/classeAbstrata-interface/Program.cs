using classeAbstrata_interface.Models;
using classeAbstrata_interface.Interfaces;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
