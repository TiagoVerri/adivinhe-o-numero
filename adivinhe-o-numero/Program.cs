// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Adivinhe o número \n");

int num2 = 0;
bool a = false;
Random rand = new Random();
int value = rand.Next(0, 100);

do
{
    Console.WriteLine("Digite um número \n");
    num2 = int.Parse(Console.ReadLine());
    if (num2 == value)
    {
        Console.WriteLine("Parabéns você acertou!!");
        a = true;
    }
    if (num2 < value)
    {
        Console.WriteLine("Tente um número mais alto");
    }
    if (num2 > value)
    {
        Console.WriteLine("Tente um número mais baixo");
    }
} while (!a);
