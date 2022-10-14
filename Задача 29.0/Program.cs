//Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// ==============================
// var1

Console.Clear ();
Console.Write ("Введите первое чисел: ");
int num1 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите второе чисел: ");
int num2 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите третье чисел: ");
int num3 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите четвертое чисел: ");
int num4 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите пятое чисел: ");
int num5 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите шестое чисел: ");
int num6 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите седьмое чисел: ");
int num7 = int.Parse (Console.ReadLine ()!);
Console.Write ("Введите восьмое чисел: ");
int num8 = int.Parse (Console.ReadLine ()!);

int[] arr = { num1, num2, num3, num4, num5, num6, num7, num8};

void printArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write (", " );
        }
    }
}

printArray(arr);
