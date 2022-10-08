// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= num; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (num > 0)
// {
//     num /= 10;
//     count += 1;
// }
// Console.WriteLine(count);

// int num = 4;
// int sum = 1;
// for (int i = 1; i < num; i++)
// {
//     sum = sum + sum * i;
//     Console.WriteLine(sum);
// }

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,2);
//     Console.Write($"{array[i]}, ");
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Console.WriteLine("Введите число A:");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i < numB; i++)
// {
//     Console.Write(Math.Pow(numA, numB));
// }

// Console.WriteLine("Введите число A:");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int sum = 1;
// for (int i = 1; i <= numB; i++)
// {
//     sum = sum * numA;
// }
// Console.Write($"Число {numA} в степени {numB} = {sum}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (num > 0)
// {
//     sum = sum + num % 10;
//     num /= 10;
// }
// Console.WriteLine($"Сумма чисел = {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,10);
//     Console.Write($"{array[i]}, ");
// }