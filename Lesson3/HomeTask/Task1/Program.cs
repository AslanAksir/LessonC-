int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int j = 0;
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > 9 && numbers[i] < 91)
    {
        j = j+1;
    }
}
Console.Write(j);
