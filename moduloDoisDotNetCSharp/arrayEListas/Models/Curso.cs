using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using sintaxeBasicaModulo2.Models;

namespace arrayEListas.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados ()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListaAluno()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}