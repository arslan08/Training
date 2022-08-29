
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
if (x == 2)
{
    chetverc("<", ">");
}
if (x == 3)
{
    chetverc("<", "<");
}
if (x == 4)
{
    chetverc(">", "<");
}