using System;
class Hello {
  static void Main() {
    Console.Write("Введите число: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Вы ввели число {0}", x);
  }
}