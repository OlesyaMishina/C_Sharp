// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 

Console.WriteLine("Enter an integer:");
long num = Math.Abs(Convert.ToInt64(Console.ReadLine()));
long[] Array2;
Array2 = GetArray(num);
if (Palindrom(Array2) == true)
    Console.WriteLine("Это палиндром!");
else if (Palindrom(Array2) == false)
    Console.WriteLine("Это НЕ палиндром!");


// фукция записывает число в массив
long[] GetArray(long num)
{
    int count = (int)Math.Log10(num) + 1;
    long[] array = new long[count];
    int j = count - 1;
    for (int i = 0; i < count; i++)
    {
        array[j] = num % 10;
        num = (num - array[j]) / 10;
        j--;
    }
    return array;
}

// фукция проверки палиндромности числа

bool Palindrom(long[] a)
{
    bool result = false;
    for (int i = 0; i < a.Length / 2; i++)
    {
        if (a[i] == a[a.Length - 1 - i])
        {
            result = true;
        }
        else
        {
            result = false;
            break; ;
        }
    }
    return result;
}