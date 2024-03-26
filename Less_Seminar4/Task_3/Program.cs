// Задача № 3
//Заполнить массив на N (вводится с консоли, не более 8) случ-ых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд находится на 0-м индексе, младший - на последнем.
// [1 3 2 4 2 3] => 132423     [2 3 1] => 231


int[] CreateArrayRndInt(int size, int min, int max) // Функция создания массива случ-ых чисел
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++) // для прохода по всем эл-там массива цикл "фор"
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array) // Функция вывода массива на экран
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}

int ArrToNumber(int[] arr)  // Функция решения нашей задачи (перед основных входом в программу)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++) // Идем по массиву
    {
        num = num * 10 + arr[i] ; //  1 * 10 + 3 и т.д.    (Т.к. накопительное num, то num +=)
    }
    return num; // Получаем число и возвращаем в накопитель
}

Console.Write("Задайте размер массива, но не болле 8 эл-тов = "); // запрос на ввод
int size = Convert.ToInt32(Console.ReadLine()); // ввод с клав-ры N чисел
if (size < 1 || size > 8) // Условие проверки
{
    Console.WriteLine("Некорректный ввод");
    return; // ВЫХОД из всей программы ( не иф завершает. а мейн(точка входа в прил-ие))
}

int[] arr = CreateArrayRndInt(size, 1, 10); // вызов массива
PrintArray(arr); // видим, какой массив выводится

int result = ArrToNumber(arr);
Console.WriteLine();
Console.WriteLine(result);