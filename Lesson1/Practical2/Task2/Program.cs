//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

float coordX = 0;
float coordY = 0;

while(coordX == 0)
{
Console.WriteLine("Введите координату X, отличную от 0");
coordX = float.Parse(Console.ReadLine());
}

while(coordY == 0)
{
Console.WriteLine("Введите координату Y,  отличную от 0");
coordY = float.Parse(Console.ReadLine());
}

if(coordX > 0 && coordY > 0)
{
    Console.WriteLine("1");
}
if(coordX < 0 && coordY > 0)
{
    Console.WriteLine("2");
}
if(coordX < 0 && coordY < 0)
{
    Console.WriteLine("3");
}
if(coordX > 0 && coordY < 0)
{
    Console.WriteLine("4");
}