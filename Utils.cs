using System;
class Utils {
  public static int Greater(int a, int b) 
  {
    if (a > b)
        return a;
    else 
        return b;
  }
}
class Programm {
    static void Main() {
  int x;
  int y;

  Console.Write("Введите первое число: ");
  x = int.Parse(Console.ReadLine());
  Console.Write("Введите второе число: ");
  y = int.Parse(Console.ReadLine());
  int greater = Utils.Greater(x, y);
  Console.WriteLine("Большим из числел {0} и {1} является {2}", x, y, greater);
    
    }
}
