// Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. 
// Порядок элементов менять нельзя.
//[1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]

Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(n);
PrintArray(array);
SeachMinMax(array, out int min, out int max);
SeachOrder(array, min, out int MinOrder, out int MaxOrder, out int CoutnOrder);
if (CoutnOrder == 1)
    Console.WriteLine($" Последовательность не найдена :(");
else
{
    Console.WriteLine($"Длина максимальной последовательности {CoutnOrder}");
    Console.WriteLine($"Минимальная цифра последовательности {MinOrder}");
    Console.WriteLine($"Масксимальная цифра последовательности {MaxOrder}");
    Console.WriteLine();
}

// Функция ищет максимально длинную последовательность.

void SeachOrder(int[] a, int min, out int MinOrder, out int MaxOrder, out int CoutnOrder)
{
    MinOrder = 0; //минимальное значение самой длинной последовательности
    MaxOrder = 0;  //максимальное значение самой длинной последовательности
    CoutnOrder = 0;  // маскимальное количество элементов последовательности
    while (min < max)
    {
        int temp = min;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == temp)
                {
                    temp = array[j];
                    temp = temp + 1;
                    count = count + 1;
                }
            }
        }
        if (count > CoutnOrder)
        {
            MinOrder = min;
            MaxOrder = temp - 1;
            CoutnOrder = count;
        }
        min = temp + 1;
    }
}


// Функция ищет минимум и максимум массива.

void SeachMinMax(int[] a, out int min, out int max)
{
    min = a[0];
    max = a[0];
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (a[i + 1] < min)
            min = a[i + 1];
        if (a[i + 1] > max)
            max = a[i + 1];
    }
}

// Функция генерируеn Массив указанной длиной случайными числами 

int[] CreateRandomArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++) array[i] = new Random().Next(1, 20);
    return array;
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
        Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}




