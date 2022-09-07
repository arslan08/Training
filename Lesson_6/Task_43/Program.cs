Console.Write("Введите b1:");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1:");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2:");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2:");
double k2 = int.Parse(Console.ReadLine());
if (b1 != b2 & k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
else
{
    Console.WriteLine($"Прямые не пересекаються");
}

