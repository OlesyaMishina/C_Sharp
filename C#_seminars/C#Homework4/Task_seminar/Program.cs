// Cгенерировать массив из n случайных чисел . Найти сумму между минимумом и максимумом по принципу максимального количества 
// элементов между ними.
Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(n);
PrintArray(array);
Console.WriteLine($"    Cумма элементов массива между максимально отстоящими друг от друга минимумом и максимумом равна {MaxSumElement(array)}.");


// Функция находит сумму элементов между максимально отстоящих друг от друга минимума и максимума массива.
int MaxSumElement(int[] a)
{

    int minLeft = 0;
    int minRight = -1;
    int maxLeft = 0;
    int maxRight = -1;
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] < a[minLeft])
        {
            minLeft = i;
            minRight = -1;
        }
        else if (a[i] == a[minLeft]) minRight = i;

    }
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > a[maxLeft])
        {
            maxLeft = i;
            maxRight = -1;
        }
        else if (a[i] == a[maxLeft]) maxRight = i;

    }

    Console.WriteLine($"Индексы минимального (ых) элементов {minLeft}, {minRight}");
    Console.WriteLine($"Индексы максимального (ых) элементов {maxLeft}, {maxRight}");

    //вариантm 1
    int sumIndex1 = Math.Abs(minLeft - maxLeft) - 1;
    int SumMaxIndex = sumIndex1;     // максимальный диапазон индексов между минимумом и максимумом
    int SumMax = SumElement(a, minLeft, maxLeft);  //значение максимальной суммы элементов

    // вариант 2
    if (maxRight != -1)
    {
        int sumIndex2 = Math.Abs(minLeft - maxRight) - 1;
        if (sumIndex2 > SumMaxIndex)
        {
            SumMaxIndex = sumIndex2;
            SumMax = SumElement(a, minLeft, maxRight);
        }
    }

    // вариант 3
    if (minRight != -1)
    {
        int sumIndex3 = Math.Abs(minRight - maxLeft) - 1;
        if (sumIndex3 > SumMaxIndex)
        {
            SumMaxIndex = sumIndex3;
            SumMax = SumElement(a, minRight, maxLeft);
        }
    }
    return SumMax;
}

// Функция сравнивает границы и считаем сумма элементов массива между ними.
int SumElement(int[] a, int a1, int a2)
{
    int sum = 0;
    if (a1 < a2)
        for (int i = a1 + 1; i < a2; i++)
            sum = sum + a[i];
    else
        for (int i = a2 + 1; i < a1; i++)
            sum = sum + a[i];
    return sum;
}


//Функция генерируеn Массив указанной длиной случайными часлами  c 1 до 100 

int[] CreateRandomArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++) array[i] = new Random().Next(0, 100);
    return array;
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
        Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}



