Console.Clear ();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine()!);
int sqr = number2*number2;

if (number1 == sqr)
{
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}