// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(N));

string PrintNumbers(int N)
{
    if (N == 1) return 1.ToString();
    else return (N+", "+PrintNumbers(N - 1));
}

