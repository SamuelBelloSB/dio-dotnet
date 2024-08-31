Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(15);
pilha.Push(5);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(29);
foreach (int item in pilha)
{
    Console.WriteLine(item);
}
