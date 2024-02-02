// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// Начальные условия
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};

    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    int[] SumRows(int[,] array)
    {
        int [] arr = new int[array.GetLength(0)]; 
        for (int i = 0; i < array.GetLength(0); i++) //Напишите свое решение здесь
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i] += array[i,j];
            }
        }
        return arr;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    int MinIndex(int[] array)
    {
        int index = 0;
        int min = array[0]; //Напишите свое решение здесь
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                index = i;
            }
        }
        return index;
    }

    void PrintResult(int[,] numbers)
    {   
        int [] arr = SumRows(numbers);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{arr[i]} ");
        }
        int index = MinIndex(arr);//Напишите свое решение здесь
        Console.Write(index);

    }

PrintResult(numbers);