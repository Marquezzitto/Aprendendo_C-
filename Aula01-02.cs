// Comentário de uma linha

/* Comentário em bloco  
 assim eu comento varias linhas.    
 */

// Declarando variáveis

string nome;
int anoNascimento;
int idade;

// Lendo um valor e atribuindo na variável
Console.WriteLine("Digite um nome: ");
nome = Console.ReadLine();


Console.WriteLine("                                ");


Console.WriteLine("Digite o ano de nascimento ");
// Conversão de tipos
anoNascimento = Convert.ToInt32(Console.ReadLine());

// Expressão de subtração
idade = 2025 - anoNascimento;


// Escreva na tela uma saudação.
Console.WriteLine("Seja bem vindo, " + nome); // Pode ser utilizando essa sintáxe ou a da linha de baixo. 
Console.WriteLine("                                 ");
Console.WriteLine(nome + " Nasceu em: " + anoNascimento);
Console.WriteLine("                                 ");
Console.WriteLine("Então ele tem " + idade + " anos.");