Console.WriteLine("Введите точку b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
    Console.Write("Нет пересечения");

else
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых в x = {x} & y = {y}");
}