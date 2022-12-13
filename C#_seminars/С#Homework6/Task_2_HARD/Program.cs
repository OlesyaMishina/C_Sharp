// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. 
//Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
MinMaxArray(Matrix);

void GetArray(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            m[i, j] = new Random().Next(-99, 100);
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

void MinMaxArray(int[,] m)
{
    int min = m[0, 0];
    int max = m[0, 0];
    int minI = 0;
    int minJ = 0;
    int maxI = 0;
    int maxJ = 0;
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            if (m[i, j] < min)
            {
                min = m[i, j];
                minI = i;
                minJ = j;
            }
    }
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            if (m[i, j] > max)
            {
                max = m[i, j];
                maxI = i;
                maxJ = j;
            }
    }
    Console.WriteLine($"Минимальное значение массива {min} имеет индекс {minI}, {minJ}.");
    Console.WriteLine($"Максимальное значение массива {max} имеет индекс {maxI}, {maxJ}.");
}