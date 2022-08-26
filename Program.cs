// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int M = 8;
int min = 777, max = int.MaxValue;
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max);
}
for (int i = 0; i < array.Length; i++)
{
Console.WriteLine(array[i] + " ");
}