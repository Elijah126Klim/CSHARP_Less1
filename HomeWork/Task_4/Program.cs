// Задача № 4
// Прорамма: на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
// Резуьтат выходит обратным порядком (не получилоась выяснить).

Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine(num);
}
else
    {
      while (num > 0)
      {
        int currentdigit = num % 10; // Считаю, что из-за этой строки происходит обратный результат, попытки мои все тщетны.
        num /= 10;
        if (num > 0)
            {
           // Console.Write(num);
            Console.Write(currentdigit + ", ");
            }
        else
        {
            Console.Write(currentdigit);
        }

      }
    }
   
