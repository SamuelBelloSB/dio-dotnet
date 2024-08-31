using System.Threading.Tasks.Dataflow;

Queue<int> fila = new Queue<int>();
bool sair = false;
int posicao = 1;
do
{
    string? entrada;
    Console.WriteLine($"Digite 1: para adicionar {posicao} na fila.");
    Console.WriteLine($"Digite 2: para exibir primeiro e o último da fila");
    Console.WriteLine($"Digite 3: exibir a fila.");
    Console.WriteLine($"Digite 4: para remover o primeiro da fila.");
    Console.WriteLine($"Digite 5: para sair.");
    int.TryParse(entrada = Console.ReadLine(),out int parar);
    if (entrada == "1")
    {
        fila.Enqueue(posicao);
        posicao++;
    }
    switch (parar)
    {   

        case 1:
            Console.WriteLine($"Adicionando {posicao} na fila.\n");
            break;
        case 2:
            Console.WriteLine($"Exibir primeiro e o último da fila:");
            Console.WriteLine($"Primeiro da fila: {fila.First()}");
            Console.WriteLine($"Último da fila: {fila.Last()}\n");
            break;
        case 3:
            Console.WriteLine($"Exibindo fila:");
            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            break;
        case 4:
            Console.WriteLine($"Removendo o primeiro:");
            Console.WriteLine(fila.Dequeue()+"\n");
            break;
        case 5:
            sair = true;
            break;
        default:
            Console.WriteLine($"Entrada invalida");
            break;
    }
}while(sair == false);