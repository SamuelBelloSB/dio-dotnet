Console.WriteLine("Repetição utilizando 'For' para tabuada de 5:");
int numero = 5;
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

Console.WriteLine("\nRepetição utilizando While:");
int numero2 = 5;
int contador2 = 0;
while (contador2 <= 10)
{
    Console.WriteLine($"{numero2} x {contador2} = {numero2 * contador2}");
    contador2++;
}