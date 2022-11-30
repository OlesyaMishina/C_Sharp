// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Enter an integer:");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Cube(num);

// Функция вычисления кубов
void Cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{Math.Pow(i, 3)}");
    }
}

