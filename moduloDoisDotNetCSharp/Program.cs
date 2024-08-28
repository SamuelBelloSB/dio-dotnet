using moduloDoisDotNetCSharp.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Samuel";
pessoa1.Sobrenome = "Bello";

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Kazuha";
pessoa2.Sobrenome = "Supremacy";

Curso curso1 = new Curso();
curso1.Nome = "C# curso";
curso1.Alunos = new List<Pessoa>();

curso1.AdicionarAluno(pessoa1);
curso1.AdicionarAluno(pessoa2);
curso1.ListaAluno();