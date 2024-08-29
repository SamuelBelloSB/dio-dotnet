using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.Models
{
    public class Localizacao
    {
        private string _nomeLocal;

        public Localizacao (string nome) => Nome = nome;

        public string Nome 
        { 
            get => _nomeLocal; 
            set => _nomeLocal = value; 
        }
    }
}