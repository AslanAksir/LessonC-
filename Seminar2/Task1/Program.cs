//int a = 256; //Удалить вторую цифру числа 
//int b = 891; //Удалить вторую цифру числа
Console.WriteLine("Введите число");
//int num = int.Parse(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/100;
int num3 = num%10;

int result = 10*num1 + num3;
Console.WriteLine(result);