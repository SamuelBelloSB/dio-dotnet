Console.WriteLine("Conversão para Int usando (int)");
double numeroDouble = 123.45;
int numeroInt = (int)numeroDouble; // Cast explícito de double para int
Console.WriteLine(numeroInt);

long numeroLong = 100000;
int numeroIntPequeno = (int)numeroLong; // Cast explícito de long para int
Console.WriteLine(numeroIntPequeno+ "\n");

Console.WriteLine("Conversão para Int usando Convert.ToInt32()");
double numeroDouble2 = 123.45;
int numeroInt2 = Convert.ToInt32(numeroDouble2); // Cast explícito de double para int
Console.WriteLine(numeroInt2);

long numeroLong2 = 100000;
int numeroIntPequeno2 = Convert.ToInt32(numeroLong2); // Cast explícito de long para int
Console.WriteLine(numeroIntPequeno2);