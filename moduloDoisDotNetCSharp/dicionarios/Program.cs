Dictionary<int, string> estados = new Dictionary<int, string>();

estados.Add(21, "RJ");
estados.Add(22, "RJ");
estados.Add(23, "RJ");
estados.Add(11, "SP");
estados.Add(12, "SP");
estados.Add(13, "SP");
estados.Add(27, "ES");
Console.WriteLine("Antes:");
foreach (KeyValuePair<int, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
}

estados.Remove(23);
estados[21] = "RJ valor alterado";
Console.WriteLine("\nDepois:");

foreach (KeyValuePair<int, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
}

int chave = 71;
Console.WriteLine($"\nVerificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Chave já existente.");
}
else 
{
    Console.WriteLine($"Chave disponível para ser inserida.");
}