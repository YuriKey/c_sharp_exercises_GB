// // Задача 40. Напишите программу, которая принимает на вход три
// // числа и проверяет, может ли существовать треугольник с сторонами
// // такой длины.
// //Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool Triangle(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);
}

// Console.Write("Введите длину стороны А: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите длину стороны B: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.Write("Введите длину стороны C: ");
// int C = int.Parse(Console.ReadLine()!);

int[] array = new int[3];

for(int i = 0; i < 3; i++)
{
    Console.Write("Введите длину стороны: ");
    array[i] = int.Parse(Console.ReadLine()!);
}

// if (Triangle (A, B, C))
// {
//     Console.Write("Такой треугольник существует.");
// }
// else
// {
//     Console.Write("Такого треугольника не существует.");
// }

if (Triangle (array[0], array[1], array[2]))
{
    Console.Write("Такой треугольник существует.");
}
else
{
    Console.Write("Такого треугольника не существует.");
}