// Задача со звездочкой: Написать программу для
// перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

// 1 функция: принимает строку, возвращает одномерный строковый массив.
string[] GetStrArrayFromString(string num)
{
    string[] nums = new string[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        nums[i] = num[i].ToString();
    }
    return nums;
}

// 2 функция: принимает строковый массив, преобразует в массив int, возвращает одномерный массив int.
int[] ConvertStrArrayToInt(string[] array)
{
    int[] res = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == "I")
            res[i] = 1;
        else if (array[i] == "V")
            res[i] = 5;
        else if (array[i] == "X")
            res[i] = 10;
        else if (array[i] == "L")
            res[i] = 50;
        else if (array[i] == "C")
            res[i] = 100;
        else if (array[i] == "D")
            res[i] = 500;
        else if (array[i] == "M")
            res[i] = 1000;
    }
    return res;
}

// 3 функция: принимает массив int, формирует арабское число.
int GetArabicNum(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] < array[i + 1])
        {
            res = res + (array[i + 1] - array[i]);
            i++;
        }
        else res = res + array[i];
    }
    return res;
}

Console.Clear();
Console.Write("Введите произвольное римское число: ");
string input = Console.ReadLine()!;

string[] newArray = GetStrArrayFromString(input.ToUpper());
int numArabic = GetArabicNum(ConvertStrArrayToInt(newArray));

// Console.WriteLine(string.Join(", ", GetStrArrayFromString(input))); //test f1
// Console.WriteLine(string.Join(", ", ConvertStrArrayToInt(newArray))); //test f2

if (numArabic == 0)
{
    Console.WriteLine("Введите корректное римское число.");
}
else
{
    Console.WriteLine
    ($"Введенное число {input.ToUpper()} соответствует {GetArabicNum(ConvertStrArrayToInt(newArray))} в арабской системе счисления.");
}
