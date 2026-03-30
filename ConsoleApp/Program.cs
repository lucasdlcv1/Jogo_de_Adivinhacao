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

2. Implemente uma funcionalidade de Validação de Números Repetidos

O jogador deve ser informado caso o número que está tentando adivinhar já tenha sido informado anteriormente na mesma rodada.

3. Implemente uma funcionalidade de Pontuação, onde:

O jogador começa com uma pontuação máxima, por exemplo, 1000 pontos.
A pontuação é calculada com base na proximidade do palpite em relação ao número secreto.
A cada tentativa errada, o jogador perde pontos de acordo com a distância do número secreto:

    Se a diferença entre o número secreto e o palpite for de 10 ou mais, o jogador perde 100 pontos.
    Se a diferença for entre 5 e 9, o jogador perde 50 pontos.
    Se a diferença for entre 1 e 4, o jogador perde 20 pontos.

Quando o jogador acerta o número, sua pontuação final é registrada.

Exemplo:
1. Número secreto: 50
2. Palpite do jogador: 30 → diferença de 20 → o jogador perde 100 pontos (de 1000 para 900).
3. Palpite do jogador: 48 → diferença de 2 → o jogador perde 20 pontos (de 900 para 880).
4. Palpite do jogador: 50 → acerto → jogo termina com 880 pontos

*/


while(true == true)
{
Console.Clear();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Jogo de adivinhação");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("1 - Fácil - Números de 1 a 20 com 10 tentativas");
Console.WriteLine("2 - Médio - Números de 1 a 50 com 5 tentativas");
Console.WriteLine("3 - Difícil - Números de 1 a 100 com 3 tentativas");
Console.WriteLine("--------------------------------------------");

Console.Write("Selecione um nivel de dificuldade: ");
string dificuldade = Console.ReadLine();

int numeroAleatorio = 0;
int totalTentativas = 10;
int pontuacao = 1000;

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

int[] entradas=new int[totalTentativas];

while(totalTentativas > 0)
{

Console.Clear();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Tentativas restantes: " + totalTentativas);
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Sua pontuação é de: " + pontuacao);
Console.WriteLine("--------------------------------------------");
Console.Write("Digite um numero: ");
string strNumeroDigitado = Console.ReadLine();

int numeroDigitado = Convert.ToInt32(strNumeroDigitado);


for(int i = 0; i < entradas.Length; i++)
        {
            while (numeroDigitado == entradas[i])
            {
                Console.WriteLine("Você já digitou esse número.");
                Console.WriteLine("Digite enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Tentativas restantes: " + totalTentativas);
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Sua pontuação é de: " + pontuacao);
                Console.WriteLine("--------------------------------------------");
                
                Console.Write("Digite outro numero: ");
                strNumeroDigitado = Console.ReadLine();

                numeroDigitado = Convert.ToInt32(strNumeroDigitado);
                continue;
            }
        }

entradas[totalTentativas - 1] = numeroDigitado;

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
            Console.WriteLine("\nO numero aleatorio era: " + numeroAleatorio + "\n");
            Console.WriteLine("Pressione Enter para jogar novamente");
            Console.ReadLine();
            break;

        }

if(Math.Abs(numeroDigitado - numeroAleatorio) > 10)
        {
            pontuacao = pontuacao - 100;
        }
else if(Math.Abs(numeroDigitado - numeroAleatorio) > 5)
        {
            pontuacao = pontuacao - 50;
        }
        else
        {
            pontuacao = pontuacao - 20;
        }

Console.WriteLine("Pressione Enter para continuar...");

Console.ReadLine();

}
}
