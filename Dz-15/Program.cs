Console.WriteLine("Введите число от 1 до 7: ");
int N1 = int.Parse(Console.ReadLine());

if (N1 > 0 && N1 <8) 
    {
        int a1 = N1 / 6; /* делим на 6 - остаетя целочисленный остаток 1 */
        if (a1 == 1)
        {
            Console.Write("Да");
        }
        else
        {
            Console.Write("Нет");
        }

    }
        
else
{Console.Write("неверное число"); 
} 


