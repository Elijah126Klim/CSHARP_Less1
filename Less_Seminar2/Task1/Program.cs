﻿Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
// num = 456798
if (num < 0) 
{
    num = num * -1;
}  
if (num > 99)
{
    while (num > 999) // 456 < 999;
    {
        num /= 10; // 4567/10=456
    }
    Console.Write($"Третья цифра = (num % 10)");
}
else
{
    Console.Write("Нет 3 цифры");
}