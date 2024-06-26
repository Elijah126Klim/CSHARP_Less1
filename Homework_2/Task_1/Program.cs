﻿// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


        Console.WriteLine("Введите целые числа. Для завершения введите 'q' или число, сумма цифр которого чётная.");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q") // Проверяем, является ли введенная строка символом 'q'
            {
                Console.WriteLine("Программа завершена по запросу пользователя.");
                break;
            }

            if (IsEvenDigitsSum(input)) // Проверяем, является ли сумма цифр числа чётной
            {
                Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
                break;
            }
        }

    // Функция для определения, является ли сумма цифр числа чётной
    static bool IsEvenDigitsSum(string numberStr)
    {
        int sum = 0;
        foreach (char digitChar in numberStr)
        {
            if (!char.IsDigit(digitChar)) // Проверяем, является ли символ числом
            {
                return false; // Если не число, завершаем функцию и продолжаем цикл
            }

            int digit = digitChar - '0'; // Преобразуем символ в числовое значение
            sum += digit; // Добавляем значение цифры к сумме
        }

        return sum % 2 == 0; // Проверяем, является ли сумма чётной
    }
