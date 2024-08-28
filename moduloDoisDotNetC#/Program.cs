using moduloDoisDotNetC_.Models;

Pessoa pessoa1 = new Pessoa();

Console.WriteLine("Digite seu nome:");
pessoa1.Nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
pessoa1.Idade = LerIntConsole.LerIntDoConsole();
pessoa1.Apresentar();