int[] Posm = new int[4];
int[] Neg = new int[4];
for (int i = 0; i < Posm.Length; i++)
{
    Posm[i] = new Random().Next(-9, 9);
    Neg[i] = Posm[i] * -1;

}

Console.WriteLine($"[{string.Join(",", Posm)}] -> [{string.Join(",", Neg)}] ");