using System;
class Hello {
  static void Main() {
    Console.WriteLine("Вычисление значения функции y = 7x^2+3x+6");
    Console.Write("x = ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("y = {0}", 7 * Math.Pow(x, 2) + 3 * x + 6);
  }
}