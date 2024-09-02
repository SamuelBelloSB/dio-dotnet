using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace principiosPOOcomCSharp.Models
{
    // Classe abstrata
    public abstract class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}";

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {NomeCompleto}");
        }

    }
}