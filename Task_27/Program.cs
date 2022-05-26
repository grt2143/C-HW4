// Написать программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

  int FigSum(int number)
  {
    int count = Convert.ToString(number).Length;
    int adv = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
      adv = number - number % 10;
      res = res + (number - adv);
      number = number / 10;
    }
   return res;
  }

int figSum = FigSum(number);
Console.WriteLine($"Сумма цифр в числе: {figSum}");
