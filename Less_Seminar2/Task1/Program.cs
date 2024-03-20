// Написать программу: принимает на вход 3- значное число и удаляет 2-ю цифру этого числа.
// a = 256 => 26
// a = 891 => 81


Console.WriteLine("Введите 3-х значное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999 || num <= -100 && num >= -999)
{
    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 * 10 + digit3;
    Console.Write(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}
