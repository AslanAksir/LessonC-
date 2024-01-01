//Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

int firstNumber = 5;
int secondNumber = 6;

        if(firstNumber > secondNumber)
        {
            Console.WriteLine("Первое число `" + firstNumber +"` больше чем второе число `" + secondNumber + "`");
        }

        if(firstNumber < secondNumber)
        {
            System.Console.WriteLine("Первое число `" + firstNumber +"` меньше чем второе число `" + secondNumber + "`");
        }

        if(firstNumber == secondNumber)
        {
            Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
        }

//На выходе Первое число `3` меньше чем второе число `6`
firstNumber = 3;
secondNumber = 6;

if(firstNumber > secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber +"` больше чем второе число `" + secondNumber + "`");
}

if(firstNumber < secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber +"` меньше чем второе число `" + secondNumber + "`");
}

if(firstNumber == secondNumber)
{
    Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
}

//На выходе Введенные числа равны `3`
firstNumber = 3;
secondNumber = 3;

if(firstNumber > secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber +"` больше чем второе число `" + secondNumber + "`");
}

if(firstNumber < secondNumber)
{
    Console.WriteLine("Первое число `" + firstNumber +"` меньше чем второе число `" + secondNumber + "`");
}

if(firstNumber == secondNumber)
{
    Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
}