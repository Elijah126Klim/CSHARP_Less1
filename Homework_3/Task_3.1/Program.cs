// Задача 3: Задайте произвольную строку. Выясните,
// является      ли      она      палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да “55655” => Да

Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();

bool palindrome = true;

for (int i = 0; i < userInput.Length / 2; i++) // так как сравниваем сразу пару
{
    if (userInput[i] != userInput[userInput.Length - i - 1]) // != обратно
    {
        palindrome = false; // присвоение
        break;
    }

}

Console.WriteLine(palindrome ? "Строка палиндром" : "Строка не падиндром");