// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void Сheck(int nums) // проверяем корректность ввода 
{

    if (nums == '0' || nums == '1' || nums == '2'
    || nums == '3' || nums == '4' || nums == '5' || nums == '6'
    || nums == '7' || nums == '8' || nums == '9' || nums == ','
    || nums == '-')
    { }
    else
    {
        Console.WriteLine($"Введите корректные данные.");
    }
}

int[] numsArray(string newNums)         // функция  создания и заполнения массива из строки
{

    int[] newNumsArray = new int[1];

    int j = 0;

    for (int i = 0; i < newNums.Length; i++)
    {
        string newNums1 = "";

        while (newNums[i] != ',' && i < newNums.Length)
        {
            newNums1 += newNums[i];
            Сheck(newNums[i]);
            
            i++;
        }
        newNumsArray[j] = Convert.ToInt32(newNums1);    // заполняет массив значениями из строки
        if (i < newNums.Length - 1)
        {
            newNumsArray = newNumsArray.Concat(new int[] { 0 }).ToArray();    // добавляет новый элемент в конец массива
        }
        j++;
    }
    return newNumsArray;
}

void PrintArry(int[] coll)              // функция  вывода массива на печать 
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.Clear();
Console.WriteLine("Введите не более 8 чисел через запятую: ");
string? Numbers = Console.ReadLine();

Numbers = Numbers + ",";    // дополнительня запятая для обозначения конца строки

int[] NumZArray = numsArray(Numbers);

if (NumZArray.Length > 8)                       //проверка количества чисел
{
    Console.WriteLine("Введите корректное количество чисел.");
}
else
{
    int[] newNumsArray = numsArray(Numbers);
    PrintArry(newNumsArray);
}