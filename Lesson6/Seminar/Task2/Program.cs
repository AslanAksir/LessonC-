// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => ['H', 'e', 'l', 'l', 'o', '!' ]

// string str = "Hellow world";
// char cha = new char[str.Length];
// for (int i = 0; i < str.Length; i++)
// {
//     cha[i] = str[i];
//     Console.Write($"")
// }

string mayString = "Hellow world!";

char [] maChar = new char [mayString.Length];

for (int i = 0; i < mayString.Length; i++)
{
	maChar[i] = mayString[i];
}

Console.WriteLine("[" + string.Join(", " , maChar)+ "]");
