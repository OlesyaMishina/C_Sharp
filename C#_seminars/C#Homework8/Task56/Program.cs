// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
MinSumRows(Matrix);

// Метод считает сумму элементов одной строки.

int SumRow(int[,] a, int i)
{
    int sum = 0;
    for (int j = 0; j < a.GetLength(1); j++)
        sum = sum + a[i, j];
    return sum;
}

// Метод ищет минимальную сумму элементов по строкам.

void MinSumRows(int[,] a)
{
    int minSum = SumRow(a, 0);
    int rowMinSum = 0;
    for (int i = 1; i < a.GetLength(0); i++)
    {
        int sum = SumRow(a, i);
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов равна {minSum} в {rowMinSum+1} строке.");
}

// Метод заполняет массив случайными числами.
void GetArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            m[i, j] = new Random().Next(1, 21);
    }
}

//Метод выводит массив на печать.
void PrintArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            Console.Write($"{m[i, j],3}\t ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

