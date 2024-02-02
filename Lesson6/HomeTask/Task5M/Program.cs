//Программа сжигания пробелов в начале, в конце. Удаление лишних пробелов внутри.
string str = "  Строка  для теста    по сжиганию лишних  пробелов     !";
// string newStr = "";
string space = " ";
string newStr = "";
for (int i = 0; i < str.Length; i++)
{
    if (Convert.ToInt32(str[i]) == Convert.ToInt32(space[0]))
    {
        continue;
    }

    for (int j = i; j < str.Length-1; j++)
    {
        
        if (Convert.ToInt32(str[j]) == Convert.ToInt32(space[0]) && Convert.ToInt32(str[j + 1]) == Convert.ToInt32(space[0]))
        {
            continue;
        }
        newStr += str[j];
        if (j == str.Length - 2)
        {
            newStr += str[j + 1];
        }
    }
    break;
}
Console.WriteLine(newStr);
Console.Write(str);