﻿//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 0;
while((number < 10) || (number > 99))
{
    Console.WriteLine("Введите целое число больше 9 и меньше 100");
    number = Convert.ToInt32(Console.ReadLine());
}

if((number % 10) > (number / 10))
{
    Console.WriteLine("Цифра разряда единиц числа больше цифры разряда десятков числа и равна `" + number % 10 +" `");
}

if((number % 10) < (number / 10))
{
    Console.WriteLine("Цифра разряда единиц числа меньше цифры разряда десятков числа и равна `" + number / 10 +" `");
}

if((number % 10) == (number / 10))
{
    Console.WriteLine("Цифра разряда единиц числа равна цифре разряда десятков числа и равна `" + number % 10 +" `");
}