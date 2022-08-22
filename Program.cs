//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число");
int a=int.Parse (Console.ReadLine());
int count = 0;
string str = a.ToString();
  int[] b = new int[str.Length];
  for (int i = 0; i < str.Length; i++)
  {
    b[i] = int.Parse(str[i].ToString());
  if (i == 2)
  {
    Console.WriteLine(b[i]);
    count = 1;
  }
  }
   if  (count==0) Console.WriteLine("третьей цифры нет");