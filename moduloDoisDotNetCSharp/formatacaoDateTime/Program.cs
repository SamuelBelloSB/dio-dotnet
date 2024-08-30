using System.Data;

DateTime dataEHoraAtual = DateTime.Now;
Console.WriteLine($"Data e hora atual: {dataEHoraAtual}");

// Utilizando uma formataçao específica:
Console.WriteLine($"\nData e hora atual com formatação: {dataEHoraAtual.ToString("dd-MM-yyyy HH:mm")}");

// Utilizando método ToShortDateStrig | Apenas a data.
Console.WriteLine($"Método ToShortDateString: {dataEHoraAtual.ToShortDateString()}");

// Utilizando método ToShortTimeStrig | Apenas as horas e minutos
Console.WriteLine($"Método ToShortTimeString: {dataEHoraAtual.ToShortTimeString()}");

// Utilizando Parse para converter String para DateTime
DateTime convertendoStringParaDateTime = DateTime.Parse("01/06/1998 23:00");
Console.WriteLine($"Método Parse para converter String em DateTime:{convertendoStringParaDateTime}");