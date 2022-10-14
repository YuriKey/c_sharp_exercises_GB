// Задача 2
// Напишите программу, которая на вход два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear ();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine ($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine ($"Число {number2} больше числа {number1}");

}