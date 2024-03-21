// Программа: выводит 3-ю слева цифру числа или сообщает, что 3-ей цифры нет.
// 456 => 6     7812 => 1   91 => 3-ей цифры нет.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
// num = 456798

if (num < 0)
    num = num * -1;
if (num > 99)
{
    while (num > 999) // 456798 > 999; 456 < 999
    {
        num /= 10; // 456798 / 10 = 45679; 4567/10=456
    }
    Console.WriteLine($"3-я цифра = {num % 10}"); // остаток деления на 10
}
else
{
    Console.WriteLine("Нет 3-ей цифры");
}
