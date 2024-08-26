using calculadora.Models;

Calculadora calculadora_01 = new Calculadora ();
Console.WriteLine("Selecione uma função de operação:");
Console.WriteLine("Digite: 1 , para Somar");
Console.WriteLine("Digite: 2 , para Subtrair");
Console.WriteLine("Digite: 3 , para Multiplicar");
Console.WriteLine("Digite: 4 , para Dividir");
int opcao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor para y:");
int y = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        calculadora_01.Somar(x, y);
        break;
    case 2:
        calculadora_01.Subtrair(x, y);
        break;
    case 3:
        calculadora_01.Multiplicar(x, y);
        break;
    case 4:
        calculadora_01.Dividir(x, y);
        break;
    default:
        Console.WriteLine($"Valor {opcao} é invalido para operação.");
        break;
}
