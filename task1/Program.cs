string[] arrstring1 = { "Понедельник", "14", "один", "два", "три" };
string[] arrstring2 = new string[arrstring1.Length];
ArrayString3char(arrstring1, arrstring2);
PrintStringArray(arrstring2);
void ArrayString3char(string[] arrstr1, string[] arrstr2)
{
    int j = 0;
    for (int i = 0; i < arrstr1.Length; i++)
    {
        if (arrstr1[i].Length <= 3)
        {
            arrstr2[j] = arrstr1[i];
            j++;
        }
    }
}
void PrintStringArray(string[] arrstr)
{
    for (int i = 0; i < arrstr.Length; i++)
    {
        Console.Write($"{arrstr[i]} ");
    }
}
