// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите размер массива");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int [ArraySize];

void GetArray()
{
     for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int GetCountNumbers()
{
    int count=0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2==0)  //  && - и    || - или
        {
            count = count+1;
        }
    }
    return count;
}

GetArray();
// PrintArray();
int num =GetCountNumbers();
System.Console.WriteLine("Кол. = "+num);