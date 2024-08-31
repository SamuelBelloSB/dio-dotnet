try
{
 
    string[] linhaLeitura = File.ReadAllLines("Arquivos/a/arquivo_Leitura.txt");
    foreach (string linha in linhaLeitura)
    {
        Console.WriteLine(linha);
    }   
}
catch (FileNotFoundException ex)
{
    
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo solicitado: Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo solicitado: Diretório não encontrado. {ex.Message}");
}

Console.WriteLine("Programa vei até aqui");