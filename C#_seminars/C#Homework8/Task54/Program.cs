// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
SortArray(Matrix);

// Метод т элементы в каждой строке массива по убыванию. 
void SortArray(int[,] a)
{
    int temp = a[0, 0];
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1) - 1; j++)
            for (int k = j + 1; k < a.GetLength(1); k++)
                if (a[i, j] < a[i, k])
                {
                    temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }

    Console.WriteLine();
    PrintArray(a);
}

// Метод заполняет массив случайными числами.
void GetArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = new Random().Next(1, 51);
    }
}

//Метод выводит массив на печать.
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write($"{a[i, j],3}\t ");
        Console.WriteLine();
    }
}
