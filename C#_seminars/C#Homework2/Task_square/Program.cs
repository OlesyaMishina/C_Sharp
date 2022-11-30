// Напишите программу, которая принимает на вход n числа от пользователя и проверяет, является ли одно число квадратом другого.
Console.WriteLine("How many numbers You would like to enter?");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine("Enter a number:");
    array[i] = Convert.ToInt32(Console.ReadLine()); ;
}

// for (int i=0; i<count; i++) 
// {
//     Console.WriteLine($" {array[i]} ");
// }
int count2=0;
for (int j = 0; j < count; j++)
{
        for (int k = j+1; k < count; k++)
        if (array[j] == array[k] * array[k]) 
        {
        Console.WriteLine($"The number {array[j]} is the square of the number {array[k]}.");
        count2=count2+1;
        }
        else if (array[k] == array[j] * array[j]) 
        {
            Console.WriteLine($"The number {array[k]} is the square of the number {array[j]}.");
            count2=count2+1;
        }
}
if (count2==0) Console.WriteLine("Neither number is the square of the other.");
