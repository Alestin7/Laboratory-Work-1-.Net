using System;

namespace Laboratory_Work_1_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = (int)Math.Pow(a, 2);
            Console.WriteLine($"Квадрат переменной a = {result}");
        }
    }
}
