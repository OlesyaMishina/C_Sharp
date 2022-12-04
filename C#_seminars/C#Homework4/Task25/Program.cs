// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степерь числа:");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} в степени {pow} равно {Power(num, pow)}.");


int Power(int a, int b)
{
    int z = 1;
    for (int i = 1; i <= b; i++)
        z = z * a;
    return z;
}
