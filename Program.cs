// Comentário de uma lina

/*
 Bloco de linhas
 */


//Declarando variáveis
string nome;
int anoNascimento;
int idade;
//int anoAtual = DateTime.Now.Year;

//Lendo um valor e atribuindo na variável
Console.WriteLine("Digite o seu nome: "); //Console.WriteLine = escrever na linha de baixo, Console.Write = Digitar na mesma linha.
nome = Console.ReadLine();

Console.WriteLine("Digite o ano do seu nascimento: ");
//Conversão de tipos: texto para um numero (int)
anoNascimento = Convert.ToInt32(Console.ReadLine());

//expressão subtração
idade = 2025 - anoNascimento;
////Calculo para saber idade
//int idade = anoAtual - anoNascimento;

//Escreva na tela uma saudação
Console.WriteLine("Seja Bem Vindo ao Senac " + nome + "!"); // O nome fica na mesma linha do Seja bem vindo
//Console.WriteLine(nome); O nome fica abaixo do Seja bem vindo
//Console.WriteLine(nome + "nasceu em " + anoNascimento);

Console.WriteLine("Sua idade é de " + idade + " anos.");

////Declarando as variáveis
//double peso;
//double altura;
//double imc;

//Console.WriteLine("Digite o seu peso (Em Kg): ");
//peso = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite a sua altura (em metros): ");
//// Converte a entrada de texto para um número (double)
//altura = Convert.ToDouble(Console.ReadLine());

//// A função Math.Pow(altura, 2) calcula a altura ao quadrado
//imc = peso / Math.Pow(altura, 2);

//// 4. Exibindo o resultado formatado
//// O ":F2" formata o número para ter 2 casas decimais
//Console.WriteLine($"\nSeu IMC é: {imc:F2}");

//// 5. Classificando o IMC
//string classificacao;

//if (imc < 18.5)
//{
//    classificacao = "Magreza";
//}
//else if (imc >= 18.5 && imc <= 24.9)
//{
//    classificacao = "Normal";
//}
//else if (imc >= 25.0 && imc <= 29.9)
//{
//    classificacao = "Sobrepeso";
//}
//else if (imc >= 30.0 && imc <= 39.9)
//{
//    classificacao = "Obesidade";
//}
//else
//{
//    classificacao = "Obesidade Grave";
//}

//Console.WriteLine($"Classificação: {classificacao}");





