// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

string NewMass(int a) //Метод принимает целое число, возвращает строчный массив двоек и единиц.
{
    string array = "";
    while (a > 0) // Пока задаваемое число не превратится в 0, выполняем тело цикла.
    {
        array += (a % 2).ToString(); //  array = array + (a % 2).ToString();
        a /= 2;
    }
    return array;
}

int MassRev(string array) //Метод разворачивает строчный массив
{
    string result = "";
    
    for (int i = 0; i < array.Length; i++)
    {
        result += array[array.Length-1-i];
    }
    return int.Parse(result); //Парсим в целочисленный тип.
}

Console.Clear ();
Console.Write("Введите десятичное число ");
int num = int.Parse(Console.ReadLine()!);

string newArray = NewMass(num);
int num1 = MassRev(newArray);
Console.Write($"В двоичном виде: {num1}");