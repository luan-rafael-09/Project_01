// See https://aka.ms/new-console-template for more information
using Projeto_02;

Console.WriteLine("Hello, World!");
Console.WriteLine("Digite o primeiro numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int resultado = Matematica.Soma(num1,num2);
int resultado1 = Matematica.Substracao(num1, num2);
int resultado2 = Matematica.Division(num1, num2);
int resultado3 = Matematica.Multiplacacao(num1, num2);

Console.WriteLine("Soma: " + resultado);
Console.WriteLine("Substracao: " + resultado1);
Console.WriteLine("Division: " + resultado2);
Console.WriteLine("Multiplicacao: " + resultado3);

