// Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5


Console.WriteLine("Ввод натур-ого числа: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNtauralNumbers(number); // вызов метода

void PrintNtauralNumbers(int num) // дойти но 0; N=5 / без возврата знач-ия
{
    if(num == 0) return; // как только 0 => выход
    PrintNtauralNumbers(num - 1); // сохраняются в стек
    Console.Write($"{num} "); // из стека
}




