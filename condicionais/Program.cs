int quantidadeEmEstoque = 10;
int quantidadeDeCompra = 3;
bool vendaDisponivel = quantidadeEmEstoque >= quantidadeDeCompra;


if (quantidadeEmEstoque == 0)
    Console.WriteLine("Venda indisponível");
else if (vendaDisponivel) 
    Console.WriteLine("Venda Realizada");
else
    Console.WriteLine("Desculpe, mas não temos a quantidade desejada disponível");