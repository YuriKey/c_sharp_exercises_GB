//  Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue) //создаем функцию для создания массива с вручную задаваемым размером size и интервалом от minValue до maxValue
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++) 
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ChangeArray (int[] array)               // Функция замены знака элемента массива.
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i < array.Length)
        {
            array [i] *= -1;
        }
    }
}


Console.Clear();
int[] array = GetArray(12, -10, 10);         //Вызываем функцию GetArray
Console.WriteLine(String.Join(", ", array)); //один из методов печати массива через Join. Join склеивает массивы. Вызываем метод, задаем в "" разделитель и печатаемый массив.

ChangeArray (array);                        //Вызываем функцию ChangeArray
Console.WriteLine(String.Join(", ", array));