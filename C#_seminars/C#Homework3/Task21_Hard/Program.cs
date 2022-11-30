// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

try
{
    Console.WriteLine("Введите размерность пространства");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] dot1 = new int[n];
    int[] dot2 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату первой точки");
        dot1[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату первой точки");
        dot2[i] = Convert.ToInt32(Console.ReadLine());
    }

    System.Console.WriteLine(GetDis(dot1, dot2));
}
catch
{
    System.Console.WriteLine("Вводим только целые числа");
}

double GetDis(int[] a1, int[] b1)
{
    double sum = 0;
    for (int i = 0; i < a1.Length; i++)
    {
        sum = sum + Math.Pow(a1[i] - b1[i], 2);
    }
    return Math.Sqrt(sum);
}