//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое число:");
int num=Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSum(num)}. ");
// фукция записывает число в массив и считает сумму его элементов.
int GetSum(int b)
{
    int count = (int)Math.Log10(b) + 1;
    int[] array = new int[count];
    int j = count - 1;
    int sum=0;
    for (int i = 0; i < count; i++)
    {
        array[j] = b % 10;
        sum=sum+array[j];
        b = (b - array[j]) / 10;
        j--;
    }
    return sum;
}

