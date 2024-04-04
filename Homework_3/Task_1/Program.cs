// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

char[,] CreateMatrixChar(int row, int column)
{
    Random rnd = new Random();
    char[,] charMatrix = new char[row, column];
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            charMatrix[i, j] = (char)rnd.Next('a', 'z' + 1);
        }
    }
    return charMatrix;
}

void PrintCharMatrix(char[,] charMatrix)
{
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            Console.Write($"{charMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

string CharMatrixToString(char[,] charMatrix)
{
    string str = "";
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            str += charMatrix[i, j];
        }
    }
    return str;
}

char[,] charMatrix = CreateMatrixChar(3, 3);

PrintCharMatrix(charMatrix);

string str = CharMatrixToString(charMatrix);

Console.WriteLine(str);
