// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ResultArray(int[] array)                              //Задаем функцию, перемножающую соответствующие элементы 
{
    int size = array.Length / 2;                            //Задаем переменную size, равную половине длины массива.
    if (array.Length % 2 != 0)                              //Проверяем на четность количества элементов.
    {                                                       //"Если длина массива, деленная пополам, не равна нулю, "
        size++;                                             //"добавляем к переменной size единицу."
    }

    int[] result = new int[size];                           //Создаем результирующий массив-накопитель, равный размером size.
    for (int i = 0; i < array.Length / 2; i++)              //"Пока счетчик i меньше половины массива"
    {
        result[i] = array[i] * array[array.Length - 1 - i]; //"Кладем в результирующий массив итый элемент массива(array[i], умноженный на соответствующий ему с конца (array[array.Length - 1 - i]))"

    }
    if (array.Length % 2 != 0)                              //"Если количество элементов массива нечетное"
    {
        result[size-1] = array[array.Length/2];             //"Кладем в последний элемент результирующего массива средний элемент исходного."
    } 
    return result;
}

Console.Clear();
Console.WriteLine("Введите массив через пробел: ");
string input = Console.ReadLine()!;
int[] numArray = GetArrayFromString(input);

int[] newArray = ResultArray (numArray);

Console.WriteLine(String.Join(", ", newArray));