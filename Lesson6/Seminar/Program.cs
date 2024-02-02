int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;

int FindElementByPosition(int[,] array, int x, int y)
{
    int element = array[x, y]; //Напишите свое решение здесь
    return FindElementByPosition;
}

bool ValidatePosition(int[,] array, int x, int y)
{
    if (x < array.GetLength(0) && y < array.GetLength(1)) //Напишите свое решение здесь
    {
        return true;
    }
    if (x >= array.GetLength(0))
    {
        Console.Write("Позиция по рядам выходит за пределы массива");
    }
    if (y >= array.GetLength(1))
    {
        Console.Write("Позиция по колонкам выходит за пределы массива");
    }
    return false;
}

void PrintResult(int[,] numbers, int x, int y)
{
    bool Criteria = ValidatePosition(numbers, x, y);
    if (Criteria == true)
    {
        Console.Write("Элемент массива с индексом [x, y] равен + {number[x, y]}");  //Напишите свое решение здесь
    }    
}

PrintResult(numbers, x, y);