//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int a = 7;
int b = 23;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if((number % a) == 0 && (number % b) == 0)
{
Console.WriteLine("Число является кратным и "+ a + " и " + b);
}
else
{
Console.WriteLine("Число не является кратным одновременно и "+ a + " и " + b);
}
