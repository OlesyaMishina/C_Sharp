// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите количество строк и столбцов массива n*n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[n, n];
FillSpiralArray(Matrix, n);
PrintArray(Matrix);


// Метод заполняет массив по спирали.
void FillSpiralArray(int[,] a, int n)
{

    int i = 0;
    int j = 0;
    for (int element = 1; element <= n * n; element++)
    {
        a[i, j] = element;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
}

//Метод выводит массив на печать.
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] < 10)
                Console.Write($" 0{a[i, j]}\t");
            else
                Console.Write($"{a[i, j],3}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
