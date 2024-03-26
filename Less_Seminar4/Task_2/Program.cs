// Задача № 2
// задать массив их N случ-ых целых чисел (N вводится с клав-ры).
// Найти кол-во чисел, которые оканчиваюся на 1 и делятся нацело на 7.
// [1 5 11 '21' 81 4 0 '91' 2 3] => 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; // тело метода, пустой массив (заполненный 0-ми по-умолч) (реализуем наш алгоритм)
    Random rnd = new Random();

    for (int i = 0; i < size; i++) // для прохода по всем эл-там массива цикл "фор"
    {
        array[i] = rnd.Next(min, max);
    }

    return array; // должны вернуть int[] (переменную)
}

void PrintArray(int[] array) // Вывод массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) // Определяем все индексы для всех чисел, кроме последнего
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

int CountTasknums(int[] array, int lastNum, int mult) // создаем функцию
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) // проход по всем эл-ам массива
    {
        // if (array[i] % 7 == 0 && array[i] % 10 == 1)
        if (array[i] % 10 == lastNum && array[i] % mult == 0)
        {
            count++;
        }

    }
    return count;
}


Console.WriteLine("Задайте размер массива:"); // запрос на ввод
int n = Convert.ToInt32(Console.ReadLine()); // ввод с клав-ры N чисел

int[] arr = CreateArrayRndInt(n, 1, 100); // вызов массива
PrintArray(arr);

int result = CountTasknums(arr, 1, 7);
Console.WriteLine();
Console.WriteLine(result);

int result2 = CountTasknums(arr, 7, 9);
Console.WriteLine();
Console.WriteLine(result2);

