// string[] names = new string[x];
// int[] num = new int[5];
// int[] num = new int[5]{1, 2, 3, 4, 5};
// int[] num = new int[]{1, 2, 3, 4, 5};

// string[] names = {"Anna", "Jhone"};
// Console.WriteLine(names[0]);

// int[] array = new int[]{1, 2, 3};
// array[1] = array[1] * 2;
// Console.WriteLine(array[1]);

// string[] names = new string[]{"Mark, John"};
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// int x = -12;
// int y = Math.Abs(x);
// Console.WriteLine(y);

// double x = 3;
// double y = Math.Pow(2, x);
// Console.WriteLine(y);

// double x = 9;
// double y = Math.Sqrt(47);
// Console.WriteLine(y);

// double x = 9.233;
// Console.WriteLine(Math.Round(x));

// До каких знаков запятой округлять
// double x = 9.233;
// Console.WriteLine(Math.Round(x, 2));

// int x = 5;
// for (int i = 1; i <= x; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }

// int y = Convert.ToInt32(Console.ReadLine());
// int x = Convert.ToInt32(Console.ReadLine());
// if (y > 0 && x > 0)
//     Console.WriteLine("Первая четверть");
// if (y > 0 && x < 0)
//     Console.WriteLine("Вторая четверть");
// if (y < 0 && x < 0)
//     Console.WriteLine("Третья четверть");
// if (y < 0 && x > 0)
//     Console.WriteLine("Третья четверть");



// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int[] array = new int[5];
// Console.WriteLine("Введите пятизначное число: ");
// int number = Int32.Parse(Console.ReadLine());
// if (number >= 10000 || number <= 99999)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = number % 10;
//         number /= 10;
//     }
//     if(array[0] == array[4] || array[1] == array[3])
//     {
//         Console.WriteLine("Полиндром");
//     }
// }

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int coub = 0;
// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"Куба числа {i}: ");
//     Console.WriteLine(Math.Pow(i, 3));
// }


