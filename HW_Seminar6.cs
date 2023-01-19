// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateArray()
// {
//     System.Console.WriteLine("Введите размер массива: ");
//     int M = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[M];
//     return array;
// }

// void FillAndPrintArray(int[] array)
// {
//     System.Console.WriteLine("ЗАПОЛНЯЕМ МАССИВ ВРУЧНУЮ(от -10 до +10):");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write("Введите элемент массива с индексом " + i + ": ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     System.Console.WriteLine("Наш массив: " + String.Join(", ", array));
// }

// int Counter (int[] array)
// {
//     int count = 0;
//     for (int i= 0; i<array.Length; i++)
//     {
//         if (array[i]>0) count++;

//     }
//     return count;
// }

// int[] Array = CreateArray();
// FillAndPrintArray(Array);
// int Count = Counter (Array);
// System.Console.WriteLine("Количество элементов массива со значением больше 0 равняется: " + Count);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double Number(string a)
// {
//     System.Console.Write("Введите чиcло " + a + ": ");
//     return Convert.ToDouble(Console.ReadLine());
// }

// double FindX(double k1, double b1, double k2, double b2)
// {
//     return (b2 - b1) / (k1 - k2);
// }

// double FindY(double k1, double x, double b1)
// {
//     return k1 * x + b1;
// }

// double k1 = Number("k1");
// double b1 = Number("b1");
// double k2 = Number("k2");
// double b2 = Number("b2");
// double X = FindX(k1, b1, k2, b2);
// double Y = FindY(k1, X, b1);
// System.Console.WriteLine("точка пересечения двух прямых: " + $"({X},{Y})");



