int quantidadeEmEstoque = 10;
int quantidadeDeCompra = 3;
bool vendaDisponivel = quantidadeEmEstoque >= quantidadeDeCompra;

Console.WriteLine("Condicional com IF:");
if (quantidadeEmEstoque == 0)
    Console.WriteLine("Venda indisponível");
else if (vendaDisponivel) 
    Console.WriteLine("Venda Realizada");
else
    Console.WriteLine("Desculpe, mas não temos a quantidade desejada disponível");

Console.WriteLine("\nCondicional com Switch Case:");
Console.WriteLine("Digite uma letra: " );
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A Letra digitada é uma Vogal!");
        break;
    
    default:
        Console.WriteLine("A Letra digitada não é uma Vogal!");
        break;
}