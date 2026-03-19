using System.Security.Cryptography;

/*

*/

// 1. O Jogo deve aceitar o input do jogador
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Jogo de adivinhacao");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.Write("Digite um numero: ");
string strNumeroDigitado = Console.ReadLine();

//gera numero de 1 a 20 (numero minimo, numero maximo(exclusivo))
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);


Console.WriteLine("O numero aleatorio3 foi: " + numeroAleatorio);

Console.ReadLine();