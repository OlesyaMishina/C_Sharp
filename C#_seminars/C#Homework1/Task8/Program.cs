// программa принимает на вход число и выдаёт все четные числа от 1 до введенного числа:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    double result = count % 2.0;
    if (result == 0) Console.Write($" {count} ");
    count++;
}
    
