// Задайте произвольную строку. Выясните, является ли она палиндромом. Продвинутая версия

string StringCreate(int StringSize, string text) //Создать строку размера StringSize из букв строки "text"
{
    Random rnd = new Random();
    string CreatedString = "";
    for (int i = 0; i < StringSize; i++)
    {
        int index = rnd.Next(0, text.Length);
        CreatedString += text[index];
    }
    return CreatedString;
}

//Сжигание всех пробелов для тестирования палиндрома

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


// Сформироать строку, в которой заглавные буквы заменены на строчные
string CreateLowCaseString(string CreatedString) 
{
    string NewString = "";
    for(int i = 0; i < CreatedString.Length; i++)
    {
        if (char.ToUpper(CreatedString[i]) == CreatedString[i])
            NewString += char.ToLower(CreatedString[i]);
        else
            NewString += CreatedString[i];
    }
    return NewString;
}

bool PalindromCheck(string StringTest) //Определить является ли строка StringTest палиндромом
{
    for (int i = 0; i < StringTest.Length / 2; i++)
    {
        if (Convert.ToInt32(StringTest[i]) != Convert.ToInt32(StringTest[StringTest.Length - i - 1]))
        {
            return false;
        }
    }
    return true;
}

void OutputPalindromMessage(string str) // Вывести сообщение о том, является ли строка str палиндромом или нет
{
    string negation = "";
    string str1 = SpaceRemoving(str);
    str1 = CreateLowCaseString(str1);
    if (PalindromCheck(str1) == false)
        negation = "не ";
    Console.Write($"Строка \"{str}\" {negation} является палиндромом");
}
// Тело программы
// string text = "abc";// создаем строку символов, из которой создастся тестируемый текст (в общем случае "qwertyuioplkjhgfdsazxcvbnm")
// int StringSize = 4;// вводим размерность тестируемого текста
// string str = StringCreate(StringSize, text);// случайным образом создаем тестируемый текст "str"

string str = "А роза упала на лапу Азора";

OutputPalindromMessage(str); //Выводим сообщение, является ли тестируемый текст палиндромомом
