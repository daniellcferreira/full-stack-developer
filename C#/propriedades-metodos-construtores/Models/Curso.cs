using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedades_metodos_construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListaAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}