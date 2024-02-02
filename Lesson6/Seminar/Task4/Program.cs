// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 0;
int y = 0;

int FindElementByPosition(int[,] array, int x, int y)
{
    return array[x-1, y-1]; //Напишите свое решение здесь    
}

bool ValidatePosition(int[,] array, int x, int y)
{
    if (x <= array.GetLength(0) && y <= array.GetLength(1)) //Напишите свое решение здесь

        return true;
    
    if (x >= array.GetLength(0))
    
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
    
    if (y >= array.GetLength(1))
    
        Console.Write("Позиция по колонкам выходит за пределы массива");
    
    return false;
}

void PrintResult(int[,] numbers, int x, int y)
{
    bool Criteria = ValidatePosition(numbers, x, y);
    if (Criteria == true)
    {
        int element = FindElementByPosition(numbers, x, y);
        Console.WriteLine($"Элемент массива с индексом [x, y] равен {element}");  //Напишите свое решение здесь
    }
}

PrintResult(numbers, x, y);