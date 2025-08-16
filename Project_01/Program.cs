// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine("Digite o ano você nasceu: ");
int ano = Convert.ToInt32(Console.ReadLine());
int resultado = 2025 -  ano;

if (resultado > 18)
{
    Console.WriteLine("Voce tem " + resultado + " anos");
}
else if (resultado < 18)
{
    Console.WriteLine("Voce tem " + resultado + " anos");
}
