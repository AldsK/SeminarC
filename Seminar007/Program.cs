// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         arr[i] = new Random().Next(100, 999);
//     }
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         Console.Write($"[{String.Join(",", arr[i])}]");
//     }
// }

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// void FillMatrix(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(-5, 10);
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
// int[,] array = new int[m,n];
// FillMatrix(array);
// PrintArray(array);

// int[,] array = new int[3,4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] += i + j;
//         Console.Write($"{array[i,j]}");
//     }
//     Console.WriteLine();
// }

// int[,] array = new int[3,4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i && j % 2 == 0)
//         {
//             array[i,j] = array[i,j] * 2;
//         }
//     }
//     Console.WriteLine();
// }

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(2,8);
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
//       Console.WriteLine();
//     }
// }

// void ChangesArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if ((i%2 == 0) && (j%2 ==0))
//             {
//                 arr[i,j] = arr[i,j] * arr[i,j];
//             }
//         }
//     }
// }
// int[,] array = new int[3,5];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangesArray(array);
// PrintArray(array);

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(2,8);
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
//       Console.WriteLine();
//     }
// }
// void ChangesArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 arr[i,j] = arr[i,j] + arr[i,j];
//             }
//         }
//     }
// }
// int[,] array = new int[4,4];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangesArray(array);
// PrintArray(array);

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// void FillArray(double[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }
// void PrintArray(double[,] arr)
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
// double[,] array = new double[3,5];
// FillArray(array);
// PrintArray(array);
// int n = 3;
// int s = 5;
// int sum = 1;
// for (int i = 1; i <= s; i++)
// {
//     sum = sum * n;
// }
// Console.WriteLine(sum);

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 9);
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

// void SearchNum(int[,] arr, int number)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (number == arr[i,j])
//             {
//                 Console.WriteLine($"Цифра {number} есть в массиве");
//                 break;
//             }
//             else
//                 {
//                     Console.WriteLine($"Цифры {number} нет в массиве");
//                 }
//         }
//     }
// }
// // МОЖЕТЕ НАПИСАТЬ СЮДА КОД, В КОТОРОМ НЕ БУДЕТ ПЕЧАТАТЬ ПОСТОЯННО Цифры 4 нет в массиве
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[3,5];
// FillArray(array);
// SearchNum(array, number);
// PrintArray(array);

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 9);
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



// void SearchSum(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i,j];
//         }
//     }
//     Console.WriteLine(sum);
// }

// int[,] arrays = new int[3,4];
// FillArray(arrays);
// PrintArray(arrays);
// Console.WriteLine();

// for (int j = 0; j < arrays.GetLength(1); j++)
// {
//     double avrg = 1;
//     for (int i = 0; i < arrays.GetLength(0); i++)
//     {
//         avrg *= arrays[i,j];
//     }
//     Console.WriteLine($"{avrg} / {arrays.GetLength(1)} = {avrg / arrays.GetLength(1)}");
// }






