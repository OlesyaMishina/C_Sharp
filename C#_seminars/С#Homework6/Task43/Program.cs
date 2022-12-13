//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Cross();

//Функция ищет точку пересечения прямых
void Cross() 
{
    Console.WriteLine("Введите коэффициент b1."); 
    double b1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Введите коэффициент k1."); 
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2."); 
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2.");
    double k2 = Convert.ToDouble(Console.ReadLine());
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2); 
        double y = k1 * x + b1; 
        Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2} имеет координаты ({x}, {y}).");
    }
    else Console.WriteLine($"Прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} точки пересечения не имеют.");
}