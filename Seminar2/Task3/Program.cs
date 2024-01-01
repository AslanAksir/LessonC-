// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите число");
//int num = int.Parse(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
//int num = int.Parse(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 % num2 == 0)
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine($"Нет, {num1% num2}");
}
