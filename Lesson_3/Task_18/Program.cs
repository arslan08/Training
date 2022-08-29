
void chetverc(string coordX, string coordY)
{
    Console.WriteLine("x " + coordX + " 0, " + "y " + coordY + " 0");
}

Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine());
if (x == 1)
{
    chetverc(">", ">");
}
else if (x == 2)
{
    chetverc("<", ">");
}
else if (x == 3)
{
    chetverc("<", "<");
}
else if (x == 4)
{
    chetverc(">", "<");
}
else
{
    Console.WriteLine("Ввели не правильный номер четверти");
}
