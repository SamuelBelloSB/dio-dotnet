using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace principiosPOOcomCSharp.Models
{
    //  Herança
    public class Professor : Pessoa
    {
        //  Construtor na herança
        public Professor(string nome) : base(nome) {}
        public decimal Salario { get; set; }

        //  Polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} e meu salário é {Salario:C}");
        }
    }
}