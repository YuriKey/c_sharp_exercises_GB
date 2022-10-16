// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArrayFromString(string stringArray)                                        //Задаем функцию, которая считывает элементы из строчного массива и запоминает элементы в целочисленный массив.
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

bool CheckArray(int[] array, int num)   //Задаем функцию, в которой проверяем, есть ли искомый элемент в заданном массиве.
{
    foreach (int el in array)           //Перебираем массив.
    {
        if (el == num)                  //"Если есть элемент, равный искомому числу"
        {
            return true;                //"возвращаем true." И функция работу останавливает.
        }
    }
    return false;                       //"В ином случае возвращаем false"
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArrayFromString(input);
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine()!);

if (CheckArray(numArray, n))    //Проверяем, есть ли число в массиве.
{
    Console.WriteLine("Да");    //Если функция проверки возвращает true. печатаем ДА.
}
else
{
    Console.WriteLine("Нет");    //Если функция проверки возвращает false. печатаем НЕТ.

}