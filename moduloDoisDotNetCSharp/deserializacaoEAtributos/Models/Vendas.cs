using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace deserializacaoEAtributos.Models
{
    public class Vendas
    {
        public Vendas (int id, string nomeProduto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }

        [JsonProperty("Data_Venda")]
        public DateTime DataVenda { get; set; }

    }
}