// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
ArithmeticColumn(Matrix);

void ArithmeticColumn(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        double sum = 0;
        double arithmetic=0;
        for (int i = 0; i < a.GetLength(0); i++)
            sum = sum + a[i, j];
        arithmetic = Math.Round(sum / a.GetLength(0),2);
        Console.WriteLine($"Среднее арифметическое {j} столбца равно {arithmetic}.");
    }
}

void GetArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            m[i, j] = new Random().Next(0, 21);
    }
}

void PrintArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            Console.Write($"{m[i, j],3}\t ");
        Console.WriteLine();
    }
}

