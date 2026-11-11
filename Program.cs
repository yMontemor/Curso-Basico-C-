// Aula 1: Introdução ao C#

 Console.WriteLine("Hello, World!"); // O console WriteLine pula linha ao final e o Write escreve na mesma linha, sem pular a próxima linha;

 Console.Write("Congratulations!");
 Console.Write(" ");
 Console.Write("You just completed your first C# program.");

 //Desafio 1: Escreva um programa que imprima as seguintes linhas no console:
 Console.WriteLine("This is the first line!");
 Console.WriteLine("This is the second line!");


// Aula 2 -> Módulo 2 - Tipos de dados em C#
Console.WriteLine('b'); // char - uso de aspas simples
Console.WriteLine("Gabriel"); // string - uso de aspas duplas
Console.WriteLine(42); // int - inteiro
Console.WriteLine(12.3m); // decimal - número com casas decimais, uso de 'm' para indicar que é um decimal
Console.WriteLine(true); // bool - valor booleano (verdadeiro ou falso)
Console.WriteLine(false); // bool - valor booleano (verdadeiro ou falso)

Console.WriteLine("123");  // string - mesmo que um número, mas tratado como texto
Console.WriteLine("true"); // string - mesmo que um valor booleano, mas tratado como texto

// Variáveis
string firstName;
firstName = "Gabriel";
Console.WriteLine(firstName);
// string firstName = "Gabriel"; // declaração e atribuição em uma única linha
string lastName = "Costa";
int age = 20;
firstName = "Jodro"; // reatribuição de valor à variável firstName
Console.WriteLine(firstName); 

// Variável local de tipo implícito 
// Uma variável de tipo implícito é uma variável em que você não precisa informar o tipo explicitamente. O C# descobre o tipo automaticamente com base no valor atribuído.
var city = "São Paulo"; // O tipo da variável é inferido pelo compilador com base no valor atribuído
var idade = 20; // O tipo da variável é inferido como int
// city = 10.1m; // Erro de compilação: não é possível atribuir um valor decimal a uma variável do tipo string

// Desafio 2:
var nome = "Lilian";
var number = 3;
var temperatura = 34.4m;
Console.WriteLine("Olá, " + nome + "! Você tem " + number + " mensagens novas. A temperatura atual é de " + temperatura + " graus Celsius.");
// Fim do Módulo 2.

// Módulo 3 
Console.WriteLine("Hello World!");
Console.WriteLine("Hello\tWorld!"); // \t é um caractere de tabulação, que adiciona um espaço horizontal
Console.WriteLine("Hello\nWorld!"); // \n é um caractere de nova linha

string fName = "Gabriel";
string greeting = "Hello";
string message = "Hello, " + fName + "!"; // concatenação de strings usando o operador +
Console.WriteLine(message);
string message2 =  greeting + " " + fName + "!"; // concatenação de strings usando o operador +
Console.WriteLine(message2);

Console.WriteLine("Hello " + nome + ", how are you?");

// Módulo 4 -> Executar operações básicas em números
int firstNumber = 10;
int secondNumber = 5;
Console.WriteLine(firstNumber + secondNumber); // Adição
Console.WriteLine(firstNumber - secondNumber); // Subtração
Console.WriteLine(firstNumber * secondNumber); // Multiplicação
Console.WriteLine(firstNumber / secondNumber); // Divisão       
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // Concatenando strings e números
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // Concatenando strings e números, mas o resultado será "Gabriel sold 77 widgets." porque a operação é feita da esquerda para a direita, então o 7 é concatenado como string
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // Concatenando strings e números, mas o resultado será "Gabriel sold 14 widgets." porque a operação é feita dentro dos parênteses primeiro, então o resultado é 14 e depois concatenado como string

int sum = 5 + 3;
int difference = 10 - 2;
int product = 4 * 6;
int quotient = 20 / 4;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 20.0m / 5; // Divisão decimal
Console.WriteLine("Decimal Quotient: " + decimalQuotient);
decimal decimalQuotient2 = 20 / 5.0m; // Divisão decimal
Console.WriteLine("Decimal Quotient 2: " + decimalQuotient2);

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5)); // Módulo - resto da divisão
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5)); // Módulo - resto da divisão

int value = 0;
value = value + 5;
value += 5;
Console.WriteLine("Value: " + value);

int value2 = 0;
value2 = value2 + 1;
value2++;
Console.WriteLine("Value2: " + value2);

int value3 = 0;

value3 = value3 + 1;
Console.WriteLine("First Increment: " + value3);

value3 += 1;
Console.WriteLine("Second Increment: " + value3);

value3++;
Console.WriteLine("Third Increment: " + value3);

////////////////////////////////////////////////

value3 = value3 - 1;
Console.WriteLine("First Decrement: " + value3);

value3 -= 1;
Console.WriteLine("Second Decrement: " + value3);

value3--;
Console.WriteLine("Third Decrement: " + value3);

int valor = 1;
valor++;
Console.WriteLine("First: " + valor);
Console.WriteLine("Second: " + valor++);
Console.WriteLine("Third: " + valor);
Console.WriteLine("Fourth: " + ++valor);

// Exercício do módulo 4.
double fahrenheit = 94;
double celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {celsius:F1} Celsius.");

//  Módulo 5 ->  Chamar métodos da Biblioteca de Classes do .NET usando C#
// Simula uma jogada de dados gerando um número aleatório e imprimindo no console.
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);