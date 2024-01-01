//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

int number = 5;
int i = 2;

while(i <= number)
{
    if(i % 2 == 0)
    {
        Console.Write(i+"\t");
        //Console.Write("\t");
    }
    i = i + 1;
}

