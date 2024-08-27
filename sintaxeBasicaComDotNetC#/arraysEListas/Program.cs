//  Array
int[] arrayDeInteiros = new int[5];
//  Utilizando o For para inserir valores no array
for (int contador = 0; contador < arrayDeInteiros.Length; contador++)
{
    Console.WriteLine($"Insira um valor para a {contador}° posição:");
    int.TryParse(Console.ReadLine(), out arrayDeInteiros[contador]);
}

