using deserializacaoEAtributos.Models;
using Newtonsoft.Json;

string listaVendas = File.ReadAllText("Arquivos/listaVenda.json");


List<Vendas> vendas = JsonConvert.DeserializeObject<List<Vendas>>(listaVendas);

foreach (Vendas item in vendas)
{
    Console.WriteLine($"Id: {item.Id}, Produto: {item.NomeProduto}, Preço: {item.Preco}, DataVenda: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}