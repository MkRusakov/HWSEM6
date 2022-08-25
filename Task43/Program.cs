// Напишите программу, которая найдёт точку пересеения двух прямых, заданных уравнением y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2 и k2 задаются пользователем.
void Coordination (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1-k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения {x} , {y}");
}
Console.Write("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
Coordination (b1, k1, b2, k2);
