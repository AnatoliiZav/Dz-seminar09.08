Console.WriteLine("Введите число: ");
int N1 = int.Parse(Console.ReadLine());

int a1 = N1 / 100;

if (a1 ==0)
{
    Console.Write("третьей цифры нет");
}
int a2 = a1 % 10;
int result = a2;
Console.Write(result);
    