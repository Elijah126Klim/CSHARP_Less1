// Задача 3
// Программа: принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру этого числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    int max = digit1;
    if (max < digit2)
    {
        max = digit2;
    }
    Console.Write($"Наибольшая цифра числа = {max}");
}


