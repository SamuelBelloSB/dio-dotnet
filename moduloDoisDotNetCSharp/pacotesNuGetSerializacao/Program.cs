using Newtonsoft.Json;
using pacotesNuGetSerializacao.Models;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVenda = new List<Venda>();

Venda venda1 = new Venda(1, "Mouse", 120.95M, dataAtual);
Venda venda2 = new Venda(2, "Teclado", 90.95M, dataAtual);

listaVenda.Add(venda1);
listaVenda.Add(venda2);

string serializacaoJson = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);
File.WriteAllText("Arquivos/listaVenda.json", serializacaoJson);

Console.WriteLine(serializacaoJson);
