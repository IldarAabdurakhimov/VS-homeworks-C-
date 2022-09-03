// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray(int m, int n)
{
  double[,] array = new double[m, n];
   for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i,j] = new Random().NextDouble() * 100;
      Console.Write(Math.Round(array[i,j],2)+ " ");
    }
     Console.WriteLine(" ");
  }
 
}

Console.WriteLine("input  M & N ");
int m=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());
Console.WriteLine(" ");

FillArray(m,n);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int[,] array)
{
  int counter=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(10,20);
      Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine(" ");
  }
  return array;
}
void FindNumber(int[,] array, int number)
{
  int counter = 0;
   for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == number)
      {
        Console.WriteLine("Число "+number+ " находится на позиции (строка/столбец) ["+(i+1)+ " , " + (j+1) +"] ");
        counter++;
      }
      
    }
  }
  if (counter ==0) Console.WriteLine("такое число отсутствует в двумерном массиве");
}

int[,] array = new int[4, 4];
Console.WriteLine("Введите число для поиска в массиве");
int number= int.Parse (Console.ReadLine());
FindNumber(FillArray(array),number);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] generate2dArray(int height = 5, int width = 7,
 int min = -10, int max = 11)
{
    int[,] result = new int[height, width];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

string prettyPrint2dArray(int[,] array)
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
    return result;
}

string prettyPrintArray(double[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

double[] rowAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j, i];
        }
        result[i] = Math.Round(result[i] / array.GetLength(0), 2);
    }
    return result;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] randomArray = generate2dArray();

Console.WriteLine("Тестовые данные: ");
Console.WriteLine(prettyPrint2dArray(testArray));
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine(prettyPrintArray(rowAverage(testArray)));


Console.WriteLine("Случайные данные: ");
Console.WriteLine(prettyPrint2dArray(randomArray));
Console.WriteLine("Среднее арифметическое столбцов: ");
Console.WriteLine(prettyPrintArray(rowAverage(randomArray)));