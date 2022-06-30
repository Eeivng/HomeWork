using System;
class Hello {
  static void Main() {
    Console.Write("Введите число х: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число у: ");
    double y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Среднее арифметическое {0}", (x + y)/2 );
    Console.WriteLine("Среднее геометрическое {0:F2}", Math.Sqrt(x * y));
  }
}
