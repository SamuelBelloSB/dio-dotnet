//  Com tuplas podemos inserir itens de tipos diferentes em uma só estrutura

/*  
Uso mais recomendo para criação de tupla porque dessa forma
podemos nomear os itens da tupla para uma semântica melhor
como no exemplo: id, nome, sobrenome e altura.
*/
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Samuel", "Bello", 1.77M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome:{tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

//  Outras formas de criação de tupla
//  Exemplo 1: aqui a própria linguagem reconhece o tipo de dado informado.
var outroExemploDeTupla = Tuple.Create(1, "Samuel", "Bello", 1.77M);

//  Exemplo 2: semelhante ao primeiro, mas sem a possibilidade de nomear os tipos para uma melhor semântica.
ValueTuple<int, string, string, decimal> outroExemploDeTupla2 = (1, "Samuel", "Bello", 1.77M);


