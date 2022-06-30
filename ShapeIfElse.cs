using System;
class Hello {
  static void Main() {
  Console.Write("x = ");
  float x = float.Parse(Console.ReadLine());
  Console.Write("y = ");
  float y = float.Parse(Console.ReadLine());
  if (x * x + y * y < 9 && y > 0)
    Console.WriteLine("Внутри");
  else if (x * x + y * y > 9 || y < 0)
    Console.WriteLine("Не внутри");
     else Console.WriteLine("На границе");
  }
}
