//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;

while((number/index/10) > 0)
{
    index = index * 10;
}

//Console.WriteLine(index);

while(index > 0)
{
    Console.Write((number/index));
    number = number%(index);
    //Console.WriteLine(number);
    index = index/10;
    if(index > 0)
    {
         Console.Write(",\t");
    }
    //Console.WriteLine(index);
}
