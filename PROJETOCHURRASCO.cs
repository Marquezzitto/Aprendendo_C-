/*CALCULADORA DE CHURRASCO*/

double carnePorPessoaKg = 0.5;
int cervejaPorPessoa = 6;
decimal precoKgCarne = 35.00m;
decimal precoLataCerveja = 2.49m;

// Variáveis de Entrada e Resultados
int convidados;
double totalCarneKg;
double totalCervejaLatas;
decimal valorTotalBruto;
decimal valorTotalFinal;
string mensagemDesconto;
double CustoCarne;
double CustoCerveja;
double valorTotalCarne;
double valorTotalCerveja;


//Entrada de dados pessoas
Console.WriteLine("******CALCULADORA KIT CHURRASCO******");
Console.Write("Quantos convidados teremos (incluindo Roberto)? ");

convidados = Convert.ToInt32(Console.ReadLine());

totalCarneKg = convidados * carnePorPessoaKg;
totalCervejaLatas = convidados * cervejaPorPessoa;

Console.WriteLine("Para esta quantidade, será necessário " + totalCarneKg + " Kg de carne " + "e " + totalCervejaLatas + " latadas de cerveja");


Console.WriteLine("********VALORES E DESCONTO********");
Console.Write("Digite o valor do Kg da Carne: ");

CustoCarne = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o valor unitário da cerveja: ");

CustoCerveja = Convert.ToDouble(Console.ReadLine());

valorTotalCarne = totalCarneKg * CustoCarne;
valorTotalCerveja = totalCervejaLatas * CustoCerveja;

Console.WriteLine("O Valor total da carne " + valorTotalCarne + "\n Valor total da cerveja " + valorTotalCerveja);
