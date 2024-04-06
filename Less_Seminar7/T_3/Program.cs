// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l   “World” => W r l d    “Hello world!” => Hllwrld

void PrintConsonants(string str, int count = 0)
{
    if (count == str.Length) return;
    string vowels = "aouiey";
    if (char.IsAsciiLetter(str[count]) == true && !vowels.Contains(char.ToLower(str[count]))) // если символ явл-ся буквой и не явля-ся гласной
    {
        Console.Write(str[count] + " ");
    }

        PrintConsonants(str, count + 1);
}

void PrintConsonants2(string str)
{
    if (str.Length == 0) return;
    string vowels = "aouiey";
    if (char.IsAsciiLetter(str[0]) == true && !vowels.Contains(char.ToLower(str[0]))) // если символ явл-ся буквой и не явля-ся гласной
    {
        Console.Write(str[0] + " ");
    }

        PrintConsonants2(str.Substring(1)); // рекурсивный вызов / дойдем до пустой строки
}

Console.WriteLine("Введите строку латинскими буквами");
string userInput = Console.ReadLine();

PrintConsonants(userInput);
PrintConsonants2(userInput);

