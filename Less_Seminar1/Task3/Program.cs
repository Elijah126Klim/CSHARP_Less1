// Написать прогу: принимает на вход 3-х значное число и на выходе показывает сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17



Console.WriteLine("Введите 3-х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int digit1 = num/100;
    int digit3 = num%10;
    int result = digit1 + digit3;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("некорректное число!");
}
