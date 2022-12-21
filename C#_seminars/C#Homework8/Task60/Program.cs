// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайные уникальные) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество страниц массива:");
int k = Convert.ToInt32(Console.ReadLine());
int[,,] Matrix = new int[m, n, k];
GetArray(Matrix);
PrintArray(Matrix);


// Метод заполняет массив случайными числами.
void GetArray(int[,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            for (int k = 0; k < a.GetLength(2); k++)
                a[i, j, k] = new Random().Next(1, 50);
    }
}

// Метод выводит массив на печать.
void PrintArray(int[,,] a)
{
    for (int k = 0; k < a.GetLength(0); k++)
    {
        for (int i = 0; i < a.GetLength(1); i++)
        {
            for (int j = 0; j < a.GetLength(2); j++)
                Console.Write($"{a[i, j, k],3}({i},{j},{k})\t");
            Console.WriteLine();
        }
    }
}

