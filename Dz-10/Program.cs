Console.WriteLine("Введите первое число : ");
int N1 = int.Parse(Console.ReadLine());

if (N1 > 99 && N1 <1000) 
    {
         int a1 = N1 / 10;
        int a2 = a1 % 10;
        int result = a2;

/* / - целочисленный остаток( 123 - 12), % - дробная часть(123 - 3) */

        Console.Write(result);
    }
        
else
{Console.Write("не трехзначное число"); 
} 

