// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа 'q' или при вводе числа, сумма цифр которого чётная.
void KeyboardInputCycle()
{
    Console.WriteLine("Введите число");
    string InputParameter = Console.ReadLine();
    while(InputParameter != "q")
    {
        int number = Convert.ToInt32(InputParameter);
        int Sum = 0;
        while(number > 0)
        {
            Sum = Sum + number % 10;
            number = number / 10;
            
        }
        if (Sum % 2 == 0)
        {
            Console.Write($"Выпало число {InputParameter} с четной суммой цифр равной {Sum}");
            break;
        }
        Console.WriteLine("Введите число");
        InputParameter = Console.ReadLine();
    }
}


KeyboardInputCycle();