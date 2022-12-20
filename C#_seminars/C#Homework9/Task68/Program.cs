// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanF(m, n));


int AkkermanF(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0) return AkkermanF(m - 1, 1);
    else return (AkkermanF(m - 1, AkkermanF(m, n - 1)));
}