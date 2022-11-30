// Задача 7, выводит третью цифру введенного числа.
Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num = Math.Abs(num1);
if (num < 100) 
{
    Console.Write($"У числа {num1} отсутствует третья цифра");
}
else
{
    while (num >= 1000)
    {
        int result = num % 10; 
        num = (num - result)/10;
    }
    int result2 = num % 10;
    Console.Write($"Третьей цифрой числа {num1} является {result2}");
}
