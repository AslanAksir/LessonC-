
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int num2 = num/10 %10;
int num3 = num %10;
int result = 1;

while(num3 > 0)
{
    result = result * num2;
    num3 = num3 - 1;
}
System.Console.WriteLine(result);

