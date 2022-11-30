// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter number from 1 to 7:");
int num = Convert.ToInt32(Console.ReadLine());
if (1 <= num && num <= 5)
    Console.WriteLine("It's a weekday :(");
if (num == 6 | num == 7)
    Console.WriteLine("It's a weekend! ;)");
else Console.WriteLine("There is no such day of the week.");
    
