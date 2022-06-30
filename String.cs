using System;
class Hello {
  static void Main() {
Console.Write("Введите строку произвольной длины: ");
string str = Console.ReadLine();
Console.Write("Введите символ для того что бы найти процент его вхождения в строку: ");
char sym = Console.ReadKey().KeyChar;
Console.WriteLine();

int length = str.Length;
char[] strArr = str.ToCharArray();
int counter = 0;
for (int i = 0; i < length; i++)
{
    if (strArr[i] == sym)
    {
        counter++;
    }
}
double lengthDouble = Convert.ToDouble(length);
double counterDouble = Convert.ToDouble(counter);
double prc = (counterDouble / lengthDouble) * 100;
Console.WriteLine($"Процент вхождения символа {sym} равен {prc:F2} %");
  }
}