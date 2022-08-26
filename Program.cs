      //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
      Console.Write("Введите число :");
      int InputNum = Convert.ToInt32(Console.ReadLine());
      int Res=0;

      while (InputNum !=0)
      {
        Res+=InputNum %10;
        InputNum /=10;
    
      }
      Console.WriteLine($"сумма цифр в числах = {Res}");
      