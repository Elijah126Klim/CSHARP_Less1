// Задача № 1
// Задать одномерный массив (тип int[]), заполненный случайными числами.             2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
// Определить кол-во простых чисел в этом массиве.  (создать метод)                     43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
// [1 3 4 19 3] => 2          [4 3 4 1 9 5 21 13] => 3

// Console.WriteLine("Hello!"); // метод - невозвращающее значение
// string str = "2024";
// int num = Convert.ToInt32(str); // возвращающее значение

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

int CountPrime(int[] array) // для опред-ия кол-ва простых чисел
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i])) // count++; // тогда счетчик увеличиваем
        {
            count++; // Если одно действие, {} можно не ставить
        }
    }
    return count;
}
// Создаем еще один метод (правда или ложь для IsPrime)
bool IsPrime(int num) // - проверяет на простоту
{
    // for (int i = 2; i < num; i++) // достаточно пройти до корня из этого числа для сокращения операций
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) // непростое число
        {
            return false;
        }
    }
    return true;
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

// Console.WriteLine();
int countPrime = CountPrime(arr);
Console.WriteLine($" => {countPrime}");




