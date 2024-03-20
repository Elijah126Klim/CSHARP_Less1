// Программа: принимать на вход два числа и выводить, является ли 1-ое число кратным 2-му. 
// Если 1-ое некратно 2-му, то программа выводит остаток от деления.
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1


int num1, num2;

Console.WriteLine("Ввод 1-ого числа");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввод 2-ого числа");
num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;
if (result == 0)
{
    Console.WriteLine("1-ое число кратно 2-му числу");
}
else
{
    Console.WriteLine($"1-ое число некратно 2-му числу\n Остаток от деления равен={result}");
}







