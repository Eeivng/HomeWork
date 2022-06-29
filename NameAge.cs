using System;
class Hello {
  static void Main() {
    string name;
    int date;
    Console.Write("Введите имя: ");
    name = Console.ReadLine();
    Console.Write("Введите год рождения: ");
    date = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("{0}, ты родился в {2}, тебе сейчас {1} лет", name, (2022 - date), date);
  }
}
