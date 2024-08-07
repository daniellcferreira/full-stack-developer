using abstracao_encapsulamento.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();


Pessoa p1 = new Pessoa();
p1.Nome = "Pedro";
p1.Idade = 30;

p1.Apresentar();
