Console.WriteLine("Введите число №1:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №3:");
int c = int.Parse(Console.ReadLine());

if (a <= b + c & b <= a + c & c <= a + b) Console.WriteLine($"Треугольник со сторонами A={a}, B={b}, C ={c} может существовать");
else Console.WriteLine($"Треугольник со сторонами A={a}, B={b}, C ={c} не может существовать");
