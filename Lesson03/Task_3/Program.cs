// Обнуление четных эл-тов массива (Ф измен-ия массива)

void ZeroEvenElements(int[] arr) // Ф принимает целочисленный массив
{
    for (int i = 0; i < arr.Length; i++) // Перебрать все эл-ты массива для поиска четнных
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }

    }
}

void PrintArray(int[] arr) // Для удобства вывода массива на экран
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 }; // Создали массив
ZeroEvenElements(array);
PrintArray(array);
