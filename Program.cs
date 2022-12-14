// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2

// int[] MakeArray(int len)
// {
//     int [] ar = new int [len];
//     for (int i = 0; i < len; i++)
//     {
//         ar[i] = new Random().Next(100, 1000);
//     }
//     return ar;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int CountEven(int[] array)
// {   
//  int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2 == 0) count++;
//     }
//  return count;
// }

// Console.Write("Enter array size ");
// int len = Convert.ToInt16(Console.ReadLine());
// if (len<1) Console.WriteLine("Array size must be greater than 0 ");
// else 
// {
// int[] array = MakeArray(len);
// PrintArray(array);
// int countEven = CountEven(array);
// Console.WriteLine("Total amount of even numbers = "+ countEven);
// }


// //Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// //Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// //Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// //[5, 18, 123, 6, 2] -> 1
// //[1, 2, 3, 6, 2] -> 0
// //[10, 11, 12, 13, 14] -> 5

// int[] FillArray()
// {
//     int [] ar = new int [123];
//     for (int i = 0; i < 123; i++)
//     {
//         ar[i] = new Random().Next(-500, 501);
//     }
//     return ar;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int FindElements(int[] array)
// {
//    int countEl = 0; 
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>9 && array[i]<100)
//         { countEl++; }
//     }
//   return countEl;
// }

// int[] array = FillArray();
// PrintArray(array);
// int result = FindElements(array);
// Console.WriteLine($"The amount of elements in [10, 99] is {result}");


// //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// //Найдите сумму элементов, стоящих на нечётных позициях.
// //[3, 7, 23, 12] -> 19        [-4, -6, 89, 6] -> 0

// int[] MakeArray(int len, int left, int right)
// {
//     int [] ar = new int [len];
//     for (int i = 0; i < len; i++)
//     {
//         ar[i] = new Random().Next(left, right + 1);
//     }
//     return ar;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int SummOddIndex(int[] array)
// {
//     int summOdd = 0;
//     for (int i = 1; i < array.Length; i = i+2)
//     {
//         summOdd = summOdd + array[i];
//     }
//     return summOdd;
// }

// Console.Write("Enter array size: ");
// int leng = Convert.ToInt32(Console.ReadLine());
// if(leng<1) Console.WriteLine("Array size must be greater than 0 ");
// else
// {
// Console.Write("Enter lower range limit: ");
// int leftLim = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Enter upper range limit: ");
// int rightLim = Convert.ToInt32(Console.ReadLine());

// if (rightLim<=leftLim) Console.WriteLine("Range limits error");
// else {
//     int[] arr = MakeArray(leng, leftLim, rightLim);
//     PrintArray(arr);
//     int sum = SummOddIndex(arr);
//     Console.WriteLine($"Summ of odd index elements is {sum}");
//     }

// }

// //Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// //максимальным и минимальным элементов массива.     [3 7 22 2 78] -> 76

// double[] MakeArray(int len)
// {
//     double [] ar = new double [len];
//     for (int i = 0; i < len; i++)
//     {
//         ar[i] = (Convert.ToDouble (new Random().Next(-1000, 1001 + 1)/10.0));
//     }
//     return ar;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// double FindMax(double[] array)
// {
//    double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>max) max = array[i];
//     }
//    return max;
// }

// double FindMin(double[] array)
// {
//    double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]<min) min = array[i];
//     }
//    return min;
// }

// Console.Write("Enter array size: ");
// int leng = Convert.ToInt32(Console.ReadLine());
// if(leng<1) Console.WriteLine("Array size must be greater than 0 ");
// else
// {
// double[] array = MakeArray(leng);
// PrintArray(array);
// double res = FindMax(array) - FindMin(array);
// Console.WriteLine($"Difference between maximum and minimum values is {res}");
// }



//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3          [6 7 3 6] -> 36 21

int[] MakeArray(int len, int left, int right)
{
    int [] ar = new int [len];
    for (int i = 0; i < len; i++)
    {
        ar[i] = new Random().Next(left, right + 1);
    }
    return ar;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Multiply(int[] array)
{
    int[] result = new int[array.Length/2]; 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[i] * array[array.Length-i-1];
    }
    return result;
}


Console.Write("Enter array size: ");
int leng = Convert.ToInt32(Console.ReadLine());
if(leng<1) Console.WriteLine("Array size must be greater than 0 ");
else
{
Console.Write("Enter lower range limit: ");
int leftLim = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter upper range limit: ");
int rightLim = Convert.ToInt32(Console.ReadLine());

if (rightLim<=leftLim) Console.WriteLine("Range limits error");
else {
    int[] arr = MakeArray(leng, leftLim, rightLim);
    PrintArray(arr);
    
PrintArray(Multiply(arr));
    }
}