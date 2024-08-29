using System.Globalization;

Console.WriteLine($"Valor monetário antes de utilizar CultureInfo:");
decimal valorMonetario = 1450.40M;
Console.WriteLine($"{valorMonetario:C}");

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

Console.WriteLine($"Valor monetário utilizando CultureInfo 'en-US':");
Console.WriteLine($"{valorMonetario:C}");
