// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// Console.WriteLine(str);
// string result;

string StringUpperToLower(string str)
{
string result = string.Empty;
for (int i = 0; i < str.Length; i++)
{
    int value = (int)(str[i]);
    if (value >= 65 && value <= 90)
    {
        result = result + (char)(value + 32);
    }
    else
    {
        result = result + str[i];
    }
}
return result;
}

Console.WriteLine("Введите строку =");

string str = Console.ReadLine();

string result = StringUpperToLower(str);

Console.WriteLine(result);
