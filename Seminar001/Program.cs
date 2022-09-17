// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первую цифру: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую цифру: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// if (numberOne > numberTwo)
// {
//     Console.Write("max: ");
//     Console.Write(numberOne);
// }
// else
// {
//     Console.Write("max: ");
//     Console.Write(numberTwo);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первую цифру: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую цифру: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третью цифру: ");
// int numberThree = Convert.ToInt32(Console.ReadLine());
// if (numberOne > numberTwo && numberOne > numberThree)
// {
//     Console.Write("Max: ");
//     Console.Write(numberOne);
// }
// if (numberTwo > numberOne && numberTwo > numberThree)
// {
//     Console.Write("Max: ");
//     Console.Write(numberTwo);
// }
// if (numberThree > numberOne && numberThree > numberTwo)
// {
//     Console.Write("Max: ");
//     Console.Write(numberThree);
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Числое нечетное");
// }
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < number; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }