// программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее:
Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine($" max={num2}, min={num1}");
}
else
{
    Console.WriteLine($" max={num1}, min={num2}");
}
