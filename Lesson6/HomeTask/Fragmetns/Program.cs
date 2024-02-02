//Работа со строкой. Получение кода символа
string str1 = " test "; // задание строки из одного пробела
char x = str1[0]; // получение значения char из символа строки
int Code = Convert.ToInt32(x); //выдает числовой код символа
Console.WriteLine(Code);//выдает 32
Code = Convert.ToInt32(str1[0]); //если задать Convert.ToInt32(str1); то не работает
Console.WriteLine(Code);//выдает 32

for (int i = 0; i < str1.Length; i++)
{
    Code = Convert.ToInt32(str1[i]);
    Console.WriteLine(Code);
}
