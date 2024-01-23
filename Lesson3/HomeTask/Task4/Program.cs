int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};

// int CountNumbersAmount()
// {
//     Console.Write("Введите число");
//     int h = 5;
//     return h;
// }

// 


int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
int CountEvenItems(int[] numbers)
    {
      int j = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        if(numbers[i] % 2 == 0)
        {
          j = j + 1;
        }
      }
      return j;
      //Напишите свое решение здесь
    }
    int counts = CountEvenItems(array);
    Console.Write(counts);