using System.Runtime.InteropServices;
using System.Security.Cryptography;

//V1
// 1. O Jogo deve aceitar o input do jogador
// 2. Gerar um numero aleatorio
// 3. o jogo dedve validaar a tentativa e dar feedback

/*
V2

1. Dificuldade e tentativas ilimitadas

O jogador tem um número limitado de tentativas para adivinhar o número.

    Fácil (intervalo 1 a 20): ≈ 10 tentativas.
    Médio (intervalo 1 a 50): ≈ 5 tentativas.
    Difícil (intervalo 1 a 100): ≈ 3 tentativas.

*/


while(true == true)
{
Console.Clear();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Jogo de adivinhacao");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("1 - Fácil - Números de 1 a 20 com 10 tentativas");
Console.WriteLine("2 - Médio - Números de 1 a 50 com 5 tentativas");
Console.WriteLine("3 - Difícil - Números de 1 a 100 com 3 tentativas");
Console.WriteLine("--------------------------------------------");
Console.Write("Selecione um nivel de dificuldade: ");
string dificuldade = Console.ReadLine();

int numeroAleatorio = 0;
int totalTentativas = 10;

switch (dificuldade)
    {
        case "1":
        totalTentativas = 10;
        numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
        break;

        case "2":
        totalTentativas = 5;
        numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
        break;

        case "3":
        totalTentativas = 3;
        numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
        break;  

        default:
        Console.WriteLine("Opção inválida");
        break;
    }

while(totalTentativas > 0)
{
Console.Clear();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Tentativas restantes: " + totalTentativas);
Console.WriteLine("--------------------------------------------");
Console.Write("Digite um numero: ");
string strNumeroDigitado = Console.ReadLine();

int numeroDigitado = Convert.ToInt32(strNumeroDigitado);


if(numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("\nParabéns, voce acertou! O numero era " + numeroAleatorio + "\n");
    Console.WriteLine("");
    Console.WriteLine("Pressione Enter para jogar novamente");
    Console.ReadLine();
    break;
}

else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("\nO numero digitado foi maior que o numero aleatorio!\n");
}

else
{
    Console.WriteLine("\nO numero digitado foi menor que o numero aleatorio!\n");
}

totalTentativas--;

if(totalTentativas == 0)
        {
            Console.WriteLine("Suas tentativas acabaram.");
            Console.WriteLine("O numero aleatorio era: " + numeroAleatorio + "\n");
        }

Console.WriteLine("Pressione Enter para jogar novamente...");

Console.ReadLine();

}
}
