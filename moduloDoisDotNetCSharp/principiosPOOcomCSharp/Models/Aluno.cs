using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace principiosPOOcomCSharp.Models
{
    //  Herança
    public class Aluno : Pessoa
    {
        //  Construtor na herança
        public Aluno(string nome) : base(nome){}

        public decimal Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e sou aluno nota {Nota}");
        }

    }
}