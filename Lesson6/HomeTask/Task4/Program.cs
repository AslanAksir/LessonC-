// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
string str = "А роза упала на лапу Азора";

int WordsAmount(string str) //Вычисляет количество слов в строке
{
    int j = 1;
    for(int i = 1; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {  
            j += 1;
        }
    }
    return j;
}

int [] WordBoundaries(string str, int spaceAmount)//Получение массива длин слов в порядке, соответствующем положению в строке
{
    int [] spaceLoc = new int [spaceAmount];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            spaceLoc[j] = i;
            j = j + 1;
        }
    }
    spaceLoc[j] = str.Length;
    return spaceLoc;
}



string [] CreateStringWordArrayInverse(string str, int [] spaceLoc, int WordAm)//Создание строкового массива слов в обратном порядке
{
    string [] WordArray = new string [WordAm];
    string stringVar = "";
    int lowspaceLoc = 0;
    int k = 0;
    for (int i =  0; i < spaceLoc.Length; i++)
    {
        for (int j = lowspaceLoc; j < spaceLoc[k]; j++)
        {
            stringVar += str[j];
        }
        WordArray[spaceLoc.Length - k -1] = stringVar;
        stringVar = "";
        lowspaceLoc = spaceLoc[k]+1;
        k = k + 1;
    }
    return WordArray;
}



string CreateStringInverse(string [] WordArray)//Формирование строки с обратным порядком слов
{
    string strInverse = string.Join(" " , WordArray);
    return strInverse;
}

void OutPutString(string str)
{
    Console.WriteLine(str);
}

void OutPutNumber(int number)
{
    Console.WriteLine(number);
}

int WordAm = WordsAmount(str);
OutPutString("Количество слов");
OutPutNumber(WordAm);
int [] spaceLoc = WordBoundaries(str, WordAm);
OutPutString("Число символов в словах");
OutPutString("[" + string.Join(", " , spaceLoc)+ "]");
string [] WordArray = CreateStringWordArrayInverse(str, spaceLoc, WordAm);
string StringInverse = CreateStringInverse(WordArray);
OutPutString("Прямая строка");
OutPutString(str);
OutPutString("Обратная строка");
OutPutString(StringInverse);
