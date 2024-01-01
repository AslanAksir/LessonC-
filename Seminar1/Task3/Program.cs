Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/100;
num = (num -num1 * 100);
int num2 = num/10;
num = num - num2 *10;
int num3 = num;

Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

Console.WriteLine("Сумма = "+(num1+num3));


