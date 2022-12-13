// На вход программы подаются одно целое число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов. 
Console.WriteLine("Введите челое число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 0)
    Console.WriteLine("0");
else
{
    for (int i = -n; i < 0; i++)
        Console.Write($"{NegaF(i)}, ");
    Console.Write($"{0}, ");
    for (int i = 1; i <= n; i++)
        Console.Write($"{F(i)}, ");
}

int F(int n)
{
    {
        if (n == 1 || n == 2) return 1;
        else return F(n - 1) + F(n - 2);
    }
}

int NegaF(int n)
{
    {
        if (n == -1) return 1;
        else if (n == -2) return -1;
        else return NegaF(n + 2) - NegaF(n + 1);
    }
}