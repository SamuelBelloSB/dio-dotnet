//  Array
int[] arrayDeInteiros = new int[5];

//  Utilizando o FOR para inserir valores no Array
Console.WriteLine("Utilizando o FOR para inserir valores no Array");
for (int contador = 0; contador < arrayDeInteiros.Length; contador++)
{
    Console.WriteLine($"Insira um valor para a {contador} posição:");
    int.TryParse(Console.ReadLine(), out arrayDeInteiros[contador]);
}

//  Percorrendo o Array utilizando FOREACH
Console.WriteLine("\nPercorrendo o Array utilizando FOREACH");
{
    int indice = 0;
    foreach (int valor in arrayDeInteiros)
    {
        Console.WriteLine($"Na posição {indice}: {valor}");
        indice++;
    }
}

//  Listas
List<string> listaDeString = new List<string>();