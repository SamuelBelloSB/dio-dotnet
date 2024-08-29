using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.Models
{
    public class Estudante
    {
        private string _nome;
        private string _sobrenome;
        
        //Sintaxe do construtor
        public Estudante (string Nome, string Sobrenome)
        {
            _nome = Nome;
            _sobrenome = Sobrenome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Sobrenome: {_sobrenome}");
        }
    }
}