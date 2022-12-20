// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(M, N));


int SumNumbers(int M, int N)
{
    if (M > N)
        (M, N) = (N, M);
    if (N == M) return M;
    else return (SumNumbers(M, N - 1) + N);
}