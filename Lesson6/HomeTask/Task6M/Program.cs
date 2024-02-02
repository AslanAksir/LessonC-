//Сжигание всех пробелов для тестирования палиндромов

string SpaceRemoving(string str)
{
    string space = " ";
    string newStr = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (Convert.ToInt32(str[i]) == Convert.ToInt32(space[0]))
        {
            continue;
        }
        newStr += str[i];    
    }
    return newStr;
}

string str = "  Строка  для теста    по сжиганию лишних  пробелов     !";
Console.WriteLine(SpaceRemoving(str));
Console.Write(str);