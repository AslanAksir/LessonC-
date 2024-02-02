// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

string str= "hello";
string vowels = "aeioyu";
int count = 0;
for (int i = 0; i < str.Length; i++)
{    
    for (int j = 0; j < vowels.Length; j++)
    {
        if (str[i] == vowels[j])
        {
            count = count + 1;
            break;
        }        
    }
}
Console.Write(count);

// string string1 = "hello";
// string string2 = "aeioyu";

// int count = 0;

// for (int i = 0; i < string1.Length; i++)
// {
//     for (int j = 0; j < string2.Length; j++)
//     {
//         if (string1[i] == string2[j])
//         {
//             count++;
//             break;
//         }
//     }
// }
// Console.WriteLine($"Колличество гласных букв в слове '{string1}' = {count}");