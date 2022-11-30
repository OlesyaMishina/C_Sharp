// Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, 
//программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. 
//Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 

// Вариант 1:
DateTime then = DateTime.Now;
for (int num = 1; num < 101; num++)
{
    if (num % 5 == 0 && num % 3 == 0)
        Console.Write("FizzBuzz  ");
    else if (num % 3 == 0)
        Console.Write("Fizz  ");
    else if (num % 5 == 0)
        Console.Write("Buzz  ");
    else Console.Write($"{num}  ");
}

DateTime now = DateTime.Now;
Console.WriteLine($"Время выполнения программы {now.Millisecond - then.Millisecond} мс");

// // Вариант 2.
// DateTime then = DateTime.Now;

// for (int num = 1; num <= 100; num++)
// {
//     if (num % 3 == 0)
//     {
//         Console.Write("Fizz  ");//         
//         if (num % 5 == 0) Console.Write("FizzBuzz  ");
//     }
//     else if (num % 5 == 0) Console.Write("Buzz  ");
//     else Console.Write($"{num}  ");
// }

// DateTime now = DateTime.Now;
// Console.WriteLine($"Время выполнения программы {now.Millisecond - then.Millisecond} мс");


// // вариант3
// DateTime then = DateTime.Now;
// for (int num = 1; num <= 100; num++)
// {
//     if (num % 3 == 0)
//         Console.Write(" Fizz");
//     if (num % 5 == 0)
//         Console.Write("Buzz ");
//     if (num % 5 != 0 && num % 3 != 0)
//         Console.Write($" {num} ");
// }
// DateTime now = DateTime.Now;
// Console.WriteLine($"Время выполнения программы {now.Millisecond - then.Millisecond} мс");