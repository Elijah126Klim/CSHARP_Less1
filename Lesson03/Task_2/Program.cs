﻿// Вывод на экран квадратов чисел от 1 до N.
void PrintSquares (int limit) // Огранич-ль кол-ва выведенных квадратов на экран
{
    int i = 1; // Создали перем-ую счетчик
    while(i <= limit) // Оформили цикл вайл
    {
        Console.Write($"{i*i} "); // Вывод квадрата числа (вывод перем-ой в строке)
        i++;
    }
}

PrintSquares(5);      // Вызов функции
PrintSquares(10);      
PrintSquares(15);     