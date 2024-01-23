// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива
double[]  numbers = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива

double min =  numbers[0];
for (int i = 1; i <  numbers.Length; i++)
{
    if (min >  numbers[i])
    {
        min =  numbers[i];
    }
}

double max =  numbers[0];
for (int i = 1; i <  numbers.Length; i++)
{
    if (max <  numbers[i])
    {
        max =  numbers[i];
    }
}

Console.Write(max - min);