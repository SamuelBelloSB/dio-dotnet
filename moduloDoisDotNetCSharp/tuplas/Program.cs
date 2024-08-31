using tuplas.Models;
// //  Com tuplas podemos inserir itens de tipos diferentes em uma só estrutura

// /*  
// Uso mais recomendo para criação de tupla porque dessa forma
// podemos nomear os itens da tupla para uma semântica melhor
// como no exemplo: id, nome, sobrenome e altura.
// */
Console.WriteLine("Formas diferentes de criar tuplas:");
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Samuel", "Bello", 1.77M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome:{tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

// //  Outras formas de criação de tupla
// //  Exemplo 1: aqui a própria linguagem reconhece o tipo de dado informado.
var outroExemploDeTupla = Tuple.Create(1, "Samuel", "Bello", 1.77M);

// //  Exemplo 2: semelhante ao primeiro, mas sem a possibilidade de nomear os tipos para uma melhor semântica.
ValueTuple<int, string, string, decimal> outroExemploDeTupla2 = (1, "Samuel", "Bello", 1.77M);


//  Utilizando tupla no retorno de métodos:
Console.WriteLine("\nUtilizando tuplas no returno de métodos tuplas:");
LeituraArquivo leitura = new LeituraArquivo();
var (sucesso, linhasArquivo, quantidadeLinhas) = leitura.LerArquivo("Arquivos/arquivoLeitura.txt");
if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas no arquivo: {quantidadeLinhas}");
    foreach (var item in linhasArquivo)
    {
        Console.WriteLine($"{item}");
    }
}
else
{
    Console.WriteLine($"Não possível ler o arquivo.");
}


//  Podemos descartar um dado do retorno da tupla utilizando "_" no lugar a onde seria armazenada
Console.WriteLine("\nDescartando um dado do retorno de um método:");
LeituraArquivo leitura2 = new LeituraArquivo();
var (sucesso2, linhasArquivo2, _) = leitura2.LerArquivo("Arquivos/arquivoLeitura.txt");
if (sucesso)
{
    // Aqui diferente do retorno da primeira tupla, optamos por não usar a quantidade de linhas, então descartamos com "_"
    foreach (var item in linhasArquivo2)
    {
        Console.WriteLine($"{item}");
    }
}
else
{
    Console.WriteLine($"Não possível ler o arquivo.");
}