// Задайте произвольную строку. Выясните, является ли она палиндромом

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

bool PalindromCheck(string StringTest) //Определить является ли строка StringTest палиндромом
{
    for (int i = 0; i < StringTest.Length/2; i++)
    {
        if (Convert.ToInt32(StringTest[i]) != Convert.ToInt32(StringTest[StringTest.Length-i-1]))
            {
                return false;
            }
    }
    return true;
}

void OutputPalindromMessage(string str) // Вывести сообщение о том, является ли строка str палиндромом или нет
{
    
    //  Console.Write(str);
    string negation = "";
    if (PalindromCheck(str) == false)
        negation = "не ";
    Console.Write($"Строка {str} {negation} является палиндромом");
}
// Тело программы
string text = "abc";// создаем строку символов, из которой создастся тестируемый текст (в общем случае "qwertyuioplkjhgfdsazxcvbnm")
int StringSize = 4;// вводим размерность тестируемого текста
string str = StringCreate(StringSize, text);// случайным образом создаем тестируемый текст "str"
OutputPalindromMessage(str); //Выводим сообщение, является ли тестируемый текст палиндромомом
