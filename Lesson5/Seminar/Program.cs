// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int [] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,100);
    System.Console.WriteLine(array[i]+ " ");
}

int count=0;

for (int i = 0; i < array.Length; i++)
{
    bool isFind =false;
   
    for (int j = 2; j < Math.Sqrt(array[i]); j++)
    {
        if(array[i] % j==0)
        {
            isFind=true;
            break;
        }
    }
    if(!isFind)
    {
        count++;
    }
}
System.Console.WriteLine("Кол. = "+ count);