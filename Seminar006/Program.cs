// Двумерный массив
// int[,] xx = {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}};
// int[,] y = new int[3,5];

// Трехмерный массив
// int[,,] xxx = new int[2,3,5];

// int[,] array = new int[2,4];
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]}");
//         }
//     Console.WriteLine();
//     }
    
// }
// FillArray(array);
// PrintArray(array);

// int[] array = {1, 2, 3, 4, 5};
// {
//     for (int i = 0; i < array.Length - 1 - i; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// Console.WriteLine($"[{String.Join(",", array)}]");

// int n = 3;
// int i = 0;
// int sum = 0;
// int sum2 = 0;
// while (n != 0)
// {   
//     sum = sum * 10 + n % 2;
//     n /= 2;
//     i++;
// }
// Console.WriteLine(sum);

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int m = 5;
// int i = 0;
// int count = 0;
// while (i < m)
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0)
//     {
//         count += 1;
//     }
//     i++;
// }
// Console.WriteLine($"Количество четных чисел: {count}");


