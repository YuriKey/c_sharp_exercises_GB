//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли это день выходным.

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 7 || num < 1)
{
    Console.WriteLine("Введите корректную цифру");
}
else 
{
    if (num >= 6)
    {
        Console.WriteLine("Это выходной.");
    }
    else
    {
        Console.WriteLine("Это будний день.");
    }
}