// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
GetArray(Matrix);
PrintArray(Matrix);
SearchElement(Matrix);

void SearchElement(int[,] a)
{
    Console.WriteLine("Введите число для поиска:");
    int element = Convert.ToInt32(Console.ReadLine());
    int iElement = 0;
    int jElement = 0;
    bool search = false;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == element)
            {
                search = true;
                iElement = i;
                jElement = j;
            }
        }

    }
    if (search == true)
        Console.WriteLine($"Элемент {element} находится в массиве под индексом [{iElement}, {jElement}].");
    else Console.WriteLine($"Элемента {element} в массиве не найдено.");
}

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
