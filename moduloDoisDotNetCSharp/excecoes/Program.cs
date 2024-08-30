try
{
 
    string[] linhaLeitura = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
    foreach (string linha in linhaLeitura)
    {
        Console.WriteLine(linha);
    }   
}
catch (System.Exception ex)
{
    
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Programa vei até aqui");