// Задача № 3 Считать с консоли строку, состоящую из цифр и лат. букв
// Сформировать новую строку из букв исходной строки.

string Getletters(string s) // Функция возвр-я строки, принимает на вход строку
{     // код функции
    string letters = ""; // строковая переменная, будет хранить буквы, извлеченные из строки
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;

        }

    }
    return letters;
}

string str = Console.ReadLine();
string result = Getletters(str);
Console.WriteLine(result);
