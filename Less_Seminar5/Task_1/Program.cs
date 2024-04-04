// Задача № 1
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы 
// на их квадраты.
// Пример

// 0    2 3 4 3
// 1    4 3 4 1
// 2    2 9 5 4

// 4 3 16 3
// 4 3  4 1
// 4 9 25 4

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) // 3 x 4
{
    //                        0      1
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // row 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // colums 4
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
