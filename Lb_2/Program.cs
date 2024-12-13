using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше число: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введіть друге число");
        string input2 = Console.ReadLine();

        double num1 = Convert.ToDouble(input1);
        double num2 = Convert.ToDouble(input2);

        Console.WriteLine($"Сума: {num1 + num2}");
        Console.WriteLine($"Різниця: {num1 - num2}");
        Console.WriteLine($"Добуток: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Частка: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на нуль неможливе!");
        }
    }
}