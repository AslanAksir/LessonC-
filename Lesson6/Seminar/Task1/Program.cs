// char[] array = new char[]{'e', '$', '9',};
// array[2] = 'e';

// string r = "ывапролд";

// // r[0] = 'r'; // не работает

// System.Console.Wr

//Задача 1
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char [] array = new char[]{'j','6',')','й',};

string str = "";

for (int i = 0; i < array.Length; i++)
{
    str = str+ array[i];
}
System.Console.WriteLine(str);