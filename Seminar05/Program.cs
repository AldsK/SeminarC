// ВАЖНО
// int x = 1234;
// int a1 = x % 10; = 4
// int a2 = x / 10 % 10; = 3
// int a3 = x / 100 % 10; 2
// int a4 = x / 1000;
// x = a1 * 1000 + a2 * 100 + a3 * 10 + a4;

// Функции

// void SeyHello()
// {
//     Console.WriteLine("Hello =)");
// }
// SeyHello();

// void SeyHello(string name)
// {
//     Console.WriteLine($"hello, {name}");
// }

// string s = "Masha";

// SeyHello("Masha");
// SeyHello(s);

// void NumMax (int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         Console.WriteLine($"Число {num1} больше {num2}");
//     }
//     else 
//     {
//         Console.WriteLine($"Число {num2} больше {num1}");
//     }
// }
// NumMax(1, 3);
// int a = 8;
// int b = 2;
// NumMax(a, b);

// int NumMax(int a, int b)
// {
//     int max = 0;
//     int min = 0;
//     if (a > b)
//     {
//         max = a;
//         return max;
//     }
//     else 
//     {
//         min = b;
//         return min;
//     }
// }
// // int num = NumMax(888, 111);
// // Console.WriteLine(num);
// Console.WriteLine($"Максимальное число: {NumMax(2, 3)}");

// int[] array = new int[5];
// int positiv = 0;
// int negativ = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write($"[{array[i]},]");
    
//     if(array[i] > 0)
//     {
//         positiv += array[i];
//     }
//     if(array[i] < 0)
//     {
//         negativ += array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел: {positiv}");
// Console.WriteLine($"Сумма отрицательных чисел: {negativ}");

// int[] array = new int[2];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write($"[{array[i]}]");
//     if (array[i] < 0)
//     {
//         array[i] *= -1;
//         Console.Write($"[{array[i]}]");
//     }
//     if (array[i] > 0)
//     {
//         array[i] *= -1;
//         Console.Write($"[{array[i]}]");
//     }
// }
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
//     Console.Write($"[{array[i]}");
//     if (num == array[i])
//     {
//         Console.WriteLine($"Такая цифра есть: {num}");
//     }
//     else
//     {
//         Console.WriteLine("Такой цифра нет");
//     }
// }

// int[] array = new int[123];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 1000);
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine(count);

// int[] array = new int[]{2, 2, 3, 4, 5};
// int sum = 0;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     sum = sum + array[i] * array[array.Length -1];
// }
// Console.WriteLine(sum);

// int[] array (int size)
// {
//     int[] mass = new int[size];
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         mass[i] = new Random().Next(-9, 10);
//         Console.Write(mass[i] + " ");
//     }
//     return mass;
// }
// array(5);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         result[i] = new Random().Next(100, 999);
//     }
//     return result;
// }
// int[] array = GetArray(5);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int sumPositiveNum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         sumPositiveNum += 1;
//     }
// }
// Console.WriteLine($"Сумма позитивных чисел: {sumPositiveNum}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         result[i] = new Random().Next(1, 100);
//     }
//     return result;
// }
// int[] array = GetArray(5);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sum += array[i];
//     }
// }
// Console.WriteLine($"Сумма чисел на нечетныъ позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 100);
// }
// Console.WriteLine($"[{String.Join(",", array)}]");
// int sum = 0;
// int max = array[0];
// int min = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//         // Console.WriteLine(max);
//     }
//     if(array[i] < min)
//     {
//         min = array[i];
//         // Console.WriteLine(min);
//     }
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");

