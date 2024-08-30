string[] linhaLeitura = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhaLeitura)
{
    Console.WriteLine(linha);
}