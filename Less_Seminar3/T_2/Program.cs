﻿// Задача № 2
// Задайте массив из 10 эл-тов, заполненный из промежутка
// [-10, 10]. Замените отриц-ые эл-ты на полож-ые, а полож-ые
// на отрицательные. [1 -5 6] => [-1 5 -6]

int[] arr = new int[10] { -5, -3, 2, 4, 5, -2, -7, 8, 10, 2 };

for (int i = 0; i < arr.Length; i++)
{
    // arr[i] = arr[i] * -1;
    arr[i] *= -1;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
