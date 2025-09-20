//declarando variáveis
string nome;
int anoNascimento;
int idade;

//lendo um valor e atribuindo na variável
Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite seu ano de nascimento:");
//conversão de tipos
anoNascimento = Convert.ToInt32(Console.ReadLine());
//expressão de subtração
idade = 2025 - anoNascimento;

//Escreva na tela uma saudação.
Console.WriteLine("Seja bem vindo: " + nome);
Console.WriteLine(nome + " nasceu em: " + anoNascimento);
Console.WriteLine("Então ele tem " + idade + "anos");



