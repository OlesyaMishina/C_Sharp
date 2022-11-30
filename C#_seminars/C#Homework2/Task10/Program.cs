// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Enter three-digit number:");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int output = (num%100-num%10)/10;
Console.WriteLine($"The secont digit of number {num} is: {output}");