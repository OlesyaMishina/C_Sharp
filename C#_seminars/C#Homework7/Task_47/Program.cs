// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Matrix = new double[m, n];
GetArray(Matrix);
PrintArray(Matrix);

void GetArray(double[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            m[i, j] = new Random().Next(-99,100) + new Random().NextDouble();
    }
}

void PrintArray(double[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            Console.Write("{0,6:F2}\t", m[i, j]);
        Console.WriteLine();
    }
}
