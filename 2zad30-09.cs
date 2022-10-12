using System;

class Program
{
       static void Main() {
             Console.WriteLine("¬ведите катет а:"); //программа просит пользовател€ ввести переменную вещественного типа
             double a = Double.Parse(Console.ReadLine()); //в программу введены данные
             Console.WriteLine("¬ведите катет b:"); //программа просит пользовател€ ввести переменную вещественного типа
             double b = Double.Parse(Console.ReadLine()); //в программу введены данные
             double p; //программа вносит переменную вещественного типа
             p = Math.Sqrt(a * a + b * b) + a + b; //программа вычисл€ет периметр введЄнных данных
             Console.WriteLine($"периметр равен {p}"); //вывод переменных
        }
}