Console.WriteLine("Введите трехзначное число : ");
int N = int.Parse(Console.ReadLine());
int N1 = N / 100;
if ( N1 >9 || N1 <1) /* Как поставить диапазон, исключив 0? */
    {
        Console.Write("не трехзначное число");

/* / - целочисленный остаток( 123 - 12), % - дробная часть(123 - 3) */

    }
        
else
{
    int a1 = N / 10;
    int a2 = a1 % 10;
    int result = a2;
    Console.Write(result); 
} 
