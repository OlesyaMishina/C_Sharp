// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
try
{
    Console.WriteLine("Введите число:");
    decimal num = Math.Abs(Convert.ToDecimal(Console.ReadLine()));
    Console.WriteLine($"В числе {num} содержится {Count(num)} цифр.");
}
catch 
{
    Console.WriteLine($"Если вы вводите дробное число, используйте ','");
}
// фукция находит количество цифр в числе.
int Count(decimal AllNum)
{
    int whole = 0; // целая часть
    decimal remains = AllNum; //дробная часть
    while (remains >= 1)
    {
        remains = remains - 1;
        whole = whole + 1;
    }
    int count = (int)Math.Log10(whole) + 1; // количество цифр в целой части
    remains = AllNum - whole;
    while (0 < remains && remains < 1)      // если есть дробная часть
    //    while (remains>=1) 
    {
        remains = remains * 10;
        count = count + 1;
        while (remains >= 1)
            remains = remains - 1;

    }
    return count;
}
