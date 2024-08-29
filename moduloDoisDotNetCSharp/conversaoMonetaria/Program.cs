using System.Globalization;

Console.WriteLine($"Valor monetário antes de utilizar CultureInfo:");
decimal valorMonetario = 1450.40M;
Console.WriteLine($"{valorMonetario:C}");
// O ":C" serve para inserir a formatação da moeda

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// O culture info altera a formatação da moeda local para a formatação inserida nos parâmetros, no caso para Americano en-US
Console.WriteLine($"Valor monetário utilizando CultureInfo 'en-US':");
Console.WriteLine($"{valorMonetario:C}");
