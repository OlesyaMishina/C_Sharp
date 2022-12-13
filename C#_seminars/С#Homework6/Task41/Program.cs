// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите длину массива:"); 
int m = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[m]; 
int count = CountPositive(array); 
Console.WriteLine($"В массиве содержится {count} положительных значений."); 

// Функция записывает с клавиатуры массив и считает количество положительных значений массива.
int CountPositive(int[] a) 
{
    Console.WriteLine($"Введите {m} целых чисел, после ввода каждого числа нажмите 'enter'."); // 
    for (int i = 0; i < m; i++) 
        array[i] = Convert.ToInt32(Console.ReadLine());  
    int count = 0; 
    for (int i = 0; i < a.Length; i++) 
    {
        if (a[i] > 0) 
            count = count + 1; 
    }
    return count; 
}





