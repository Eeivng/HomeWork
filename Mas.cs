using System;
class Hello {
  static void Main() {
    int Sum = 0;
    Console.Write("Введите длину массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] mas = new int [n];
    Random ran = new Random();
    for (int i = 0; i < mas.Length; i++){
        mas[i] = ran.Next(0,1000);
    }
    for (int i = 0; i < mas.Length; i++){
    Console.Write(mas[i] + ", ");
    }
    for (int i = 0; i < mas.Length; i++) {Sum += mas[i];}
    Console.Write("Сумма элементов массива: " + Sum);
    
  }
}
