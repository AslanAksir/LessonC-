// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string StringCreate(int StringSize, string text) //Случайным образом создать строку размера StringSize из латинских букв  
                                                //  из элементов строки "text" в обоих регистрах.
{
    Random rnd = new Random();
    string CreatedString = "";
    for (int i = 0; i < StringSize; i++)
    {
        int index = rnd.Next(0, text.Length);
        int letterCase = rnd.Next(0, 2);
        if (letterCase == 0)
        {
            CreatedString += char.ToUpper(text[index]);
        }        
        else
        {
            CreatedString += text[index]; 
        }           
    }
    return CreatedString;
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

//Тело программы
string text = "qwertyuioplkjhgfdsazxcvbnm";
int StringSize = 20;
string str = StringCreate(StringSize, text);
 Console.WriteLine(str);
 Console.Write(CreateLowCaseString(str));

