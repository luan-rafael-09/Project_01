
String name;
int idade;
Console.WriteLine("Digite seu nome: ");
name = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());


int resultado = DateTime.Now.Year - idade;

Console.WriteLine("Nome: " + name + " Ano do nascimento: " + resultado);
