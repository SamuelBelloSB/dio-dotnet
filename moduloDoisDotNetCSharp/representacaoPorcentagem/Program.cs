// Representação de porcentagem utilizando o '.' e o 'P' 
double porcentagem = .9465; // O '.' aqui faz com que todos os numeros venham dps da virgula
Console.WriteLine(porcentagem);
Console.WriteLine(porcentagem.ToString("P")); // O 'P' converte o valor em porcentagem, gerando uma dezena com os 2 numeros dps da virgula.
Console.WriteLine($"{porcentagem:P}"); // Outra forma de usar o 'P'
Console.WriteLine($"{porcentagem:P3}"); // Adicionando casas decimais
Console.WriteLine($"{porcentagem:P}");