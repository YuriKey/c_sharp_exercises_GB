// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

int[] GetArrayFromString(string stringArray) // Задаем функцию, которая считывает элементы из строчного массива и запоминает элементы в целочисленный массив.
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // Объявляем новый массив, заполняемый методом Split. В скобках указываем критерий, 
                                                                                   //по которму выделяются элементы. Здесь это пробел. StringSplitOptions.RemoveEmptyEntries - предостерегает от ошибки, если пустая строка.
                                                                                   //Если мы введем "1 22 31 4", Split выдаст массив [1, 22, 31, 4]/
    int[] res = new int[nums.Length];                                              //Здесь создаем результирующий массив-накопитель для вывода результата.

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);                                              //В цикле проходим по массиву и конвертируем string в int.
    }
    return res;
}

int[] NewArray2(int[] inArray) //Задаем метод, который копирует заданный массив.
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

Console.Clear();
Console.Write("Введите целые числа через пробел: ");
string input = Console.ReadLine()!;
int[] newArray = GetArrayFromString(input);

Console.WriteLine(String.Join(" ", NewArray2(newArray)));