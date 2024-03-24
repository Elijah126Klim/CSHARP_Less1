// Задача № 4
// Дано натур-ое 3-х знач-ое число. Создать массив,
// состоящий из цифр этого числа. Младший разряд числа должен
// располагаться на 0-м имндексе массива, старший - на 2-м.
// 456 => [6 5 4]

Console.WriteLine("Введите 3-х знач-ое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999 )
{
 Console.WriteLine("Некорректный ввод");
}
else
{
    int[] result = new int[3];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = number % 10;
        number /= 10;
    }

    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    } 
}

   





