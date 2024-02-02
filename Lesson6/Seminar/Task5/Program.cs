//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

// Печать массива
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++) //Напишите свое решение здесь
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    // PrintArray(numbers);

    // Обмен первой с последней строкой
    int[,] SwapFirstLastRows(int[,] array)
    {
        int i = array.GetLength(0)-1; //Напишите свое решение здесь
        SwapItems(array, i);
        return array;
    }

    // Обмен элементами массива
    void SwapItems(int[,] array, int i)
    {
        int i0 = 0;
        int numVar =0;
        //Напишите свое решение здесь
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numVar = array[i0,j];
            array[i0, j] = array[i, j];
            array[i, j] = numVar;            
        }
    }

    
PrintArray(numbers);
int[,] array = SwapFirstLastRows(numbers);
PrintArray(array);