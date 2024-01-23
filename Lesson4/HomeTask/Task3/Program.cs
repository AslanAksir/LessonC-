// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// void ReverseOrder(int[] array)
int [] array = {1, 2, 3, 4, 5, 6};

void ReverseOrder()
{
    int i = 0;
    int varArrayElement = array[i];
    int ArraySize = array.Length;
    while(i < ArraySize-i-1)
    {
        array[i] = array[ArraySize-1-i];
        array[ArraySize-1-i] = varArrayElement;
        i = i + 1;
        varArrayElement = array[i];       
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}


ReverseOrder();
PrintArray();
