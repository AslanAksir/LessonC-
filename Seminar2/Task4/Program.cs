﻿// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100)
{
int result = (num/100)%10;
    Console.WriteLine(result);

}
else
{
    Console.WriteLine("Третьей цифры нет");
}