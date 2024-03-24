// Задача 1.
// Задать массив. Написать программу, к-рая определяет,
// присутствует ли заданное число в массиве. (ДА/ НЕТ).
// {1 3 4 19 3}, 8 => нет       {-4 3 4 1}, 3 => да

// int[] array = new int[6] { 1, 3, 4, 19, 3, 8 };
int[] array = { 1, 3, 4, 19, 3, 8 }; // 1. Задаем исх-ые данные
int num = 3; 

 int[] arr = new int[3];
 for (int i = 0; i < arr.Length; i++)
 {
   Console.Write($"Введите {i + 1} элемент: "); // по порядку
   arr[i] = Convert.ToInt32(Console.ReadLine());
 }


// 2. Проверка исх-ых данных (при необх-ти)

// 3. Реализация логики (алгоритм)
bool res = false; //string res = "Нет";

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        res = true;
        break; // для прерывания цикла for!
    }
}
// 4. Вывод результата
// Console.WriteLine(res);
Console.WriteLine(res ? "Да" : "Нет");


