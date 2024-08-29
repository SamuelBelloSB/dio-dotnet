using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxeBasicaModulo2.Models
{
    public class Pessoa
    {
        private string? _nome;
        private int _idade;

        public string? Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        }
        public int Idade
        { 
            get => _idade;
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentException("A idade inserida não pode ser menor que zero.");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{_nome} {Sobrenome}";

        public void Apresentar()
        {
            Console.WriteLine($"Olá, seu nome é {_nome}; {_idade} anos");
        }
    }
}