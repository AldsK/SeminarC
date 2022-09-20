// int number = new Random().Next(100, 999);
// int sum = number % 10, 
//     sum2 = number / 10;
// if (sum > sum2)
// {
//     Console.WriteLine(sum);
// }
// else
// {
//     Console.WriteLine(sum);
// }
// Console.WriteLine(number);

// int number = new Random().Next(100, 999);
// Console.WriteLine(number);
// int num = number % 10,
//     num2 = number / 100,
//     num3 = num2 * 10 + num;
// Console.WriteLine(num3);

// int number = new Random().Next(10, 99);
// int number2 = new Random().Next(1, 10);
// Console.WriteLine(number);
// Console.WriteLine(number2);
// if (number % number2 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.Write("Не кратно, остаток: ");
//     Console.Write(number % number2);
// }

// int number = new Random().Next(100, 999);
// Console.WriteLine(number);
// int num1 = 7,
//     num2 = 23;
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("нет");
// }
// int number = new Random().Next(1, 100);
// Console.WriteLine(number);
// int number2 = new Random().Next(1, 10);
// Console.WriteLine(number2);
// if(number * number == number2)
// {
//     Console.WriteLine("Квадрат");
// }
// else if (number2 * number2 == number)
// {
//     Console.WriteLine("Квадрат");
// }
// else
// {
//     Console.WriteLine("Не квадрат");
// }
// int number = new Random().Next(10, 100000);

// ############### HomeWork
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// int number = new Random().Next(100, 999);
// Console.WriteLine(number);
// int divNumber = number / 10;
// int result = divNumber % 10;
// Console.Write("Вторая цифра: ");
// Console.Write(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// int number = new Random().Next(1, 100000000);
// Console.WriteLine(number);
// int result = 0;
// if (number <= 99)
// {
//     Console.WriteLine("Такой цифры - нет");
// }
// while (number > 999)
// {
//     number /= 10;
//     Console.WriteLine(number); // Специально оставил печать для проверки корректной работы.
//     if (number >= 100 && number <= 999)
//     {
//         result = number % 10;
//         Console.Write("Третья цифра: ");
//         Console.Write(result);
//     }
//     number++;
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// int x = Convert.ToInt32(Console.ReadLine());
// if (x >= 1 && x <= 5)
// {
//     Console.WriteLine("Будни");
// }
// else if (x >= 6 && x <=7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Такого числа - нет");
// }

