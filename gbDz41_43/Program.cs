////41
//int Prompt(string message)
//{
//    Console.Write(message);
//    string value = Console.ReadLine();
//    int result = Convert.ToInt16(value);
//    return result;
//}
//int[] InputArray(int length)
//{
//    int[] array = new int[length];
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = Prompt($"Введите {i + 1} -й элемент ");

//    }
//    return array;
//}

//    void PrintArray(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//            Console.WriteLine($"a[{i}] = {array[i]}");
//    }


//int CountPositiveNumbers(int[] array)
//{
//    int count = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > 0)
//        {
//            count++;
//        }

//    }
//    return count;


//}
//int lenght = Prompt("Введите количество элементов >");
//int[] array;
//array = InputArray(lenght);
//PrintArray(array);
//Console.WriteLine($"Количество чисел больше 0 : " +
//    $"{CountPositiveNumbers(array)}");
//////////43
////////Console.Write("Введите k1: ");
////////var k1 = Convert.ToDouble(Console.ReadLine());
////////Console.Write("Введите b1: ");
////////var b1 = Convert.ToDouble(Console.ReadLine());
////////Console.Write("Введите k2: ");
////////var k2 = Convert.ToDouble(Console.ReadLine());
////////Console.Write("Введите b2: ");
////////var b2 = Convert.ToDouble(Console.ReadLine());


////////var x = -(b1 - b2) / (k1 - k2);
////////var y = k1 * x + b1;

////////x = Math.Round(x, 3);
////////y = Math.Round(y, 3);

////////Console.WriteLine($"Пересечение в точке: ({x};{y})");
