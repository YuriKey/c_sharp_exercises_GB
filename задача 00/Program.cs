// комментарий с текстом задачи


Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");