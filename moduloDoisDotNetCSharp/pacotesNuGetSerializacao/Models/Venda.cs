using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pacotesNuGetSerializacao.Models
{
    public class Venda
    {
        public Venda(int id, string nomeProduto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}