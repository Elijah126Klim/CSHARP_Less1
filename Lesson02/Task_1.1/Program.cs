﻿// Создать массив и заполнить его целыми числами от 1 до N
// (N - произвольное натур-ое число). Вывести эл-ты на экран.



int n = 10; // создали целочисленную переменную N
int[] arr = new int[n]; // cтандартный синтаксис создания массива (число элементов в массиве неизвестно) (оператор new типа данных)
int i = 0; // создали переменную-счетчик
           
           // для заполнения и вывода используем цикл
while (i < arr.Length) // <=свойство массива; while (i < n)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1; // переход к след. значению счетчика
}




