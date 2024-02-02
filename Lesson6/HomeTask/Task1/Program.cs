// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива

// Создание случайного двумерного массива символов размерности [LengthX, LengthY] из элементов текста "text"
char [,] CreateCharArray(string text, int LengthX, int LengthY) 
{
    char[,] charArray = new char[LengthX, LengthY];
    Random rnd = new Random();
    for (int i = 0; i < LengthX; i++)
    {
        for (int j = 0; j < LengthY; j++)
        {
            int indexText = rnd.Next(0, text.Length);
            
            charArray[i, j] = text[indexText];
        }
    }
        return charArray;
}

void ConsoleArrayPrint(char [,] Array) // Вывод на консоль двумерного массива символов
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

string CreateStringFromCharArray(char [,] Array) // Создание строки из массива символов выстраиванием последовательно строк массива
{
    string ResultString = "";
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        ResultString += Array[i,j];
    }
    return ResultString;
}

//Тело программы
string text = "qjeovkfnilsinoljlobasklmhdksjrnjdxzaswplkhbd@*,"; //Текст из элеметов которого создается двумерный массив символов
int RowSize = 5; //Размерность строк 
int ColomnSize = 6; //Размерность столбцов
char [,] charArray = CreateCharArray(text, RowSize, ColomnSize);
ConsoleArrayPrint(charArray);
string ResultString = CreateStringFromCharArray(charArray);
Console.Write(ResultString);