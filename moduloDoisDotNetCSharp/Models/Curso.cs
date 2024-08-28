using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moduloDoisDotNetCSharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }


        int ObterQuantidadeDeAlunosMatriculados ()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}