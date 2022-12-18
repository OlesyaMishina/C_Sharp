// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
SortArray(Matrix);
// Console.WriteLine(Matrix.GetLength(0));
// Console.WriteLine(Matrix.GetLength(1));

void SortArray(int[,] a)
{
    int temp = a[0, 0];
    int j = 0;
    int k = 0;
    int size = m * n;   //количество элементов в массиве
    for (int i = 0; i < size; i++)
        for (int l = 0; l < size - 1 - i; l++) //по массиву идет сквозной индекс l
        {
            j = (l + 1) / n; // номер строки двумерного массива получаем делением текущей позиции сквозного индекса на n
            k = (l + 1) % n; // остаток от деления дает номер столбца
            if (a[j, k] < a[l / n, l % n])
                // {
                (a[l / n, l % n], a[j, k]) = (a[j, k], a[l / n, l % n]);

        }
    PrintArray(a);
}

// Метод заполняет массив случайными числами.
void GetArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            m[i, j] = new Random().Next(1, 51);
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
