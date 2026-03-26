using System.Security.Cryptography;

/*

*/

// 1. O Jogo deve aceitar o input do jogador
// 2. Gerar um numero aleatorio
// 3. o jogo dedve validaar a tentativa e dar feedback
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Jogo de adivinhacao");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.Write("Digite um numero: ");
string strNumeroDigitado = Console.ReadLine();

int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

//gera numero de 1 a 20 (numero minimo, numero maximo(exclusivo))
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);


Console.WriteLine("O numero aleatoriorio foi: " + numeroAleatorio);

if(numeroDigitado == numeroAleatorio)
{
    Console.WriteLine("Parebens, voce acertou! O numero era" + numeroAleatorio);
}

else if (numeroDigitado > numeroAleatorio)
{
    Console.WriteLine("O numero digitado foi maior que o numero aleatorio!");
}

else
{
    Console.WriteLine("O numero digitado foi menor que o numero aleatorio!");
}

Console.ReadLine();