using System;

class Numbers
{
    public static void Main()
    {
        double x, y;
        Console.Write("x = ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0} / {1} = {2:F3}",x ,y ,x / y);
    }
}