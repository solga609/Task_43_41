﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

        Console.WriteLine("Введите числа через пробел: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int count = arr.Count(x => x > 0);
        Console.WriteLine($" Пользователь ввел {count} числа > 0");

