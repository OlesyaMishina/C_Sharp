// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Matrix1 = { { 2, 4 }, { 3, 2 } };
// int[,] Matrix2 = { { 3, 4 }, { 3, 3 } };

Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix1 = new int[m, n];
int[,] Matrix2 = new int[m, n];
GetArray(Matrix1);
GetArray(Matrix2);
PrintArray(Matrix1);
PrintArray(Matrix2);
MultiMatrix(Matrix1, Matrix2);

// Метод ищет произведение матриц.

void MultiMatrix(int[,] a1, int[,] a2)
{
    if (a1.GetLength(0) != a1.GetLength(1))
        Console.WriteLine("Можно перемножить только квадратные матрицы.");
    Console.WriteLine();
    int[,] a = new int[2, 2];

    for (int i = 0; i < a1.GetLength(0); i++)
    {
        for (int j = 0; j < a2.GetLength(1); j++)
        {
            a[i, j] = 0;
            for (int k = 0; k < a1.GetLength(1); k++)
                a[i, j] = a[i, j] + a1[i, k] * a2[k, j];
        }
    }

    PrintArray(a);
}

// Метод заполняет массив случайными числами.
void GetArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = new Random().Next(1, 10);
    }
}

//Метод выводит массив на печать.
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write($"{a[i, j],2}\t ");
        Console.WriteLine();
    }
    Console.WriteLine();
}



