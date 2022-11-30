// программa принимает на вход число и выдаёт, является ли оно четный:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double result=num%2.0;
if (result == 0) Console.Write ($"Число {num} четное.");
else Console.Write ($"Число {num} нечетное.");
