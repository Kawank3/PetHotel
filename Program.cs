string Espécie;
string Raça;
string Nome;
int Idade;
string Pelagem;

Console.Write("Bem-vindo ao Pet Hotel \"Bom Pra Pet\"!\n");
Console.Write("Qual a espécie do seu pet? ");
Espécie = Console.ReadLine()!;
Console.Write("Qual a raça do seu pet? ");
Raça = Console.ReadLine()!;
Console.Write("Qual o nome do seu pet? ");
Nome = Console.ReadLine()!;
Console.Write("Qual a idade do seu pet? ");
Idade = int.Parse(Console.ReadLine()!);
Console.Write("Qual a pelagem/cor do seu pet? ");
Pelagem = Console.ReadLine()!;


Console.WriteLine("+=========================================================+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("                Pet Hotel ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("\"Bom Pra Pet\"                  ");
Console.ResetColor();
Console.WriteLine("|");

Console.WriteLine("+=========================================================+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(" Espécie: ............");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{Espécie}");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.ResetColor();

Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Raça: ..................");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{Raça}");
Console.ResetColor();
Console.WriteLine("|");

Console.WriteLine("+=========================================================+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(" Atende pela alcunha de: .............................");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{Nome}");
Console.ResetColor();
Console.WriteLine("|");

Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(" Idade:");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($" {Idade} ano(s) ");
Console.ResetColor();
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Pelagem/cor: ...............");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{Pelagem}");
Console.ResetColor();
Console.WriteLine("|");

Console.WriteLine("+=========================================================+");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Obrigado por usar nossos serviços! Volte sempre!");