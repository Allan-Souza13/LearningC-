int n = 0;

int r = 0;

Console.WriteLine("Determina se o número é par ou impar");
Console.WriteLine("Informe um ´número: ");

n = Convert.ToInt32(Console.ReadLine());

r = n % 2;

if (r == 1)
{
    Console.WriteLine("O nunero é impar");
}
else
{
    Console.WriteLine("O numero é Par");
}
Console.ReadKey();