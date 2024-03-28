// Задача № 1 Создать 2-мерный массив с размерами 3 х 5,
// состоящий из целых чисел. Вывести на экран.

int[,] matrix = new int[3, 5];

Random rnd = new Random();
// Заполняем массив на экран
for (int i = 0; i < matrix.GetLength(0); i++) // !проход по строкам! 
{
    for (int j = 0; j < matrix.GetLength(1); j++) // цикл осуществит !проход по эл-ам строк! (одном-го массива), запросим кол-во столбцов в этом массиве
    {

        matrix[i, j] = rnd.Next(1, 11);
    }
}

// Выводим заполненний массив на экран (также перебираем все эл-ты)
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write($"{matrix[i, j]} "); // Интерполяция строк
    }
    Console.WriteLine(); // перенос на новую строку
}




