Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int negnum = num * -1;

while(num >= negnum)
{
Console.WriteLine(negnum);
negnum = negnum + 1;
}
