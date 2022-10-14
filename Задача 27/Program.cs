// Задача 27: Напишите функцию и запустите ее, которая
//принимает на вход число и выдаёт сумму цифр в числе.

int Summ (int n)
{
    int res = 0;
    
    while ( n  > 0)
    {
        res = res + (n % 10);
        n = n / 10;
    }
    return res;
}

Console.Clear ();
Console.Write ("Введите число: ");
int N = int.Parse (Console.ReadLine ()!);
Console.WriteLine ($"Сумма цифр числа {N} равна {Summ(N)}.");