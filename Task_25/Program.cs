// Написать цикл, который принимает на вход 2 числа (A и B) и возводит число A в натуральную степень B.

  Console.WriteLine("Введите число A: ");
  int numberA = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int numberB = int.Parse(Console.ReadLine());

  int Exponent(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = res * numberA;
  }
    return res;
}
int exp = Exponent(numberA, numberB);
Console.WriteLine($"Ответ: {exp}");
