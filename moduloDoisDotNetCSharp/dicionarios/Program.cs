Dictionary<int, string> estados = new Dictionary<int, string>();

estados.Add(21, "RJ");
estados.Add(22, "RJ");
estados.Add(23, "RJ");
estados.Add(11, "SP");
estados.Add(12, "SP");
estados.Add(13, "SP");
estados.Add(27, "ES");

foreach (KeyValuePair<int, string> item in estados)
{
    Console.WriteLine(item);
}