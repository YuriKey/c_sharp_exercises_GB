// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool CheckArray(int[] array, int num)
{
    foreach (int el in array)
    {
        if (el == num)
        {
            return true;
        }
    }
    return false;
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArrayFromString(input);
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine()!);

if (CheckArray(numArray, n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");

}
