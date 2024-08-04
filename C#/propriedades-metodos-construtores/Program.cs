using propriedades_metodos_construtores.Models;

Pessoa p1 = new Pessoa("Pedro", "Henrique");
Pessoa p2 = new Pessoa("Eduardo", "Novais");

Curso cursoProgramacao = new Curso();
cursoProgramacao.Nome = "Programação";
cursoProgramacao.Alunos = new List<Pessoa>();

cursoProgramacao.AdicionarAluno(p1);
cursoProgramacao.AdicionarAluno(p2);
cursoProgramacao.ListaAlunos();