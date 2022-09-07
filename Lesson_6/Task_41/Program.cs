Console.Write("Введите числа чрез запятую:");
string UserDat = Console.ReadLine() + " ";
int ChekArr = 0;
string Tmp = string.Empty;
int[] TmpArr = new int[UserDat.Length];
for (int i = 0; i < UserDat.Length; i++)
{
    if (double.TryParse(string.Join("", UserDat[i]), out var Num) || UserDat[i] == '-') Tmp += UserDat[i];
    if (Tmp != "" & double.TryParse(Tmp, out Num))
    {
        TmpArr[ChekArr] = int.Parse(Tmp);
        ChekArr += 1;
    }
    Tmp = "";
}
Array.Resize(ref TmpArr, ChekArr);
ChekArr = 0;
foreach (var item in TmpArr) if (item > 0) ChekArr += 1;
Console.Write($"{string.Join(", ", TmpArr)} -> {ChekArr}");