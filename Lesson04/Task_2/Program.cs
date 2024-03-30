// Задача № 2
// Назовем число "интересным", если его сумма цифр четная
// Создать двумерный массив, состоящий из целых чисел. Вывести на экран "интерес-ые" эл-ты массива

int[,] CreateMatrix(int rowcount, int columCount)
{
    int[,] matrix = new int[rowcount, columCount];

    Random rnd = new Random();
    // Заполняем массив на экран
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4); // Точка входа
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }

}
bool IsInteresting(int value) // Реализация для функции IsInteresting
{
    int sumOfDigits = GetsSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    //else
    //{
    return false;
    //}
}
// Реализация фунуции GetsSumOfDigits
int GetsSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10; // получим правую цифру нашего числа
        value = value / 10; // перейти к след цифре
    }
    return sum;
}

