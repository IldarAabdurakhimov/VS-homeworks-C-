//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] randomArray(int length, int min = -100, int max = 999)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

string outArray(int[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

int countEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}
;

Console.Write("Input lenght array:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
    Console.Write("Error");
}
else
{
    int[] array = randomArray(length, 100, 1000);
    Console.Write("random array: ");
    Console.WriteLine(outArray(array));
    Console.Write("summ even-numbered: ");
    Console.WriteLine(countEvenElements(array));
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] randomArray2(int length, int min = -100, int max = 999)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

string outArray(int[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

int oddElements(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result += array[i];
    return result;
}
;

Console.Write("Input lenght array:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
    Console.Write("Error");
}
else
{
    int[] array = randomArray2(length, 100, 1000);
    Console.Write("random array: ");
    Console.WriteLine(outArray(array));
    Console.Write("summ even-numbered: ");
    Console.WriteLine(oddElements(array));
}

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double[] Array = new double[4];
  for (int i = 0; i < Array.Length; i++ )
  {
    Array[i] = new Random().Next(1, 4);
    Console.Write(Array[i] + "\t");
  }
double max = Array[0];
double min = Array[0];

  for (int i = 1; i < Array.Length; i++)
  {
    if (max < Array[i])
    {
      max = Array[i];
    }
        if (min > Array[i])
    {
      min = Array[i];
    }
  }

  double decision = max - min;

  Console.WriteLine($"Difference between max & min =sum : {decision}");