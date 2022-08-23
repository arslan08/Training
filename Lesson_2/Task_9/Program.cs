int num = new Random().Next(10, 100);
int a = num / 10;
int b = num % 10;
int max = a;
if (a < b) max = b;
Console.WriteLine("Максимальная цифра в числе " + num + " -> " + max);