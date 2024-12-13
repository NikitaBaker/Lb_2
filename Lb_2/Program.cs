using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");
            Console.WriteLine("5. Вихід");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Дякуємо за використання програми! До побачення.");
                break;
            }

            Console.Write("Введіть перше число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Неправильний ввід. Натисніть будь-яку клавішу для повернення до меню.");
                Console.ReadKey();
                continue;
            }

            Console.Write("Введіть друге число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Неправильний ввід. Натисніть будь-яку клавішу для повернення до меню.");
                Console.ReadKey();
                continue;
            }

            double result;
            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;

                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;

                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Помилка: ділення на нуль неможливе.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для повернення до меню...");
            Console.ReadKey();
        }
    }
}
