Console.Clear();
Console.Write("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine()!);

if (x >=1 && x <= 4)
{ 
    if (x == 1)
    {
        Console.Write("x > 0, y > 0");
    }
    else if (x == 2)
    {
        Console.Write("x < 0, y > 0");
    }
    else if (x == 3)
    {
        Console.Write("x < 0, y < 0");
    }
    else if (x == 4)
    {
        Console.Write("x > 0, y < 0");
    }
}
else
{
    Console.Write("Введите корректное значение");
}

// switch (x) //shift case используется, когда у каждого проверяемого значения выводы уникальны. 
// //Код более структурирован в таком случае. Если много вложенных условий, лучше писать через switchCase
// {
//     case 1: //если х = 1
//         {
//             Console.Write("x > 0, y > 0");
//             break; //обязательно прерывать
//         }
//     case 2:
//         {
//             Console.Write("x < 0, y > 0");
//             break;
//         }
//     case 3:
//         {
//             Console.Write("x < 0, y < 0");
//             break;
//         }
//     case 4:
//         {
//             Console.Write("x > 0, y < 0");
//             break;
//         }
//     case null:    //кейс, где не встретилось ни одно из значений
//         {
//             Console.Write("Введите корректное значение");
//             break;
//         }
// }
