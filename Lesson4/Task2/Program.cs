//Назовем число "интересным", если его сумм цифр четная
//Создать двумерный массив, состоящий из целых чисел. Вывести на экран "интересные" элементы массива
int[,] createMatrix(int rowCount, int colomnsCount)
{
    int[,] matrix = new int[rowCount, colomnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}



int[,] matrix = createMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int SumOfDigits = getSomeOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int getSomeOfDigits(int value)
{
    int Sum = 0;
    while(value > 0)
    {
        Sum = Sum + value % 10;
        value = value / 10;
    }
    return Sum;
}

