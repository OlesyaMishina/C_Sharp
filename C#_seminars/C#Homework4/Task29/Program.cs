// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Console.WriteLine("Введите восемь целых чисел, после ввода каждого числа нажмите 'enter'.");
int[] array = new int [8];
for (int i=0; i<8; i++)
array[i]=Convert.ToInt32(Console.ReadLine());
PrintArray(array);

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
        Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}



