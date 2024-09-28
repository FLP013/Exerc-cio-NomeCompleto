Console.Clear();

string PrimeiroNome, Sobrenome;

Console.Write("Digite seu primeiro nome: ");
PrimeiroNome = Console.ReadLine()!;

Console.Write("Digite seu Sobrenome: ");
Sobrenome = Console.ReadLine()!;

Console.Write($" Nome Completo: {PrimeiroNome} {Sobrenome}");

Console.WriteLine();

Console.Write($" Nome Catálago: {Sobrenome} {PrimeiroNome}");
