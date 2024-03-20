// Программа: принимает на вход 3-х значное число и возводит 2-ю цифру этого числа в степень, равную 3-ей цифре.
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


Console.WriteLine("Введите 3-х значное число");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
double result = 1;


if (num >=100 && num <= 999 || num <= -100 && num >= -999)
{
    int digit2 = num / 10 % 10;
    int digit3 = num % 10;
   
   // если степень отр-ая, делаем положительной
    if (digit3 < 0 )
    {
        digit3*= -1; // digit3 = digit3 * -1
    }
    
    // Алгоритм возведения в степень
    while (count < digit3)
    {
        result = result * digit2;
        count++;
    }

    // Вычисление резульата для отрицательной степени
    if (digit2 < 0)
    {
        result = 1 / result;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}