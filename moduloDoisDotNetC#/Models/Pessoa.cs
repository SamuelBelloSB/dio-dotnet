using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moduloDoisDotNetC_.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá {Nome}");
        }
    }
}