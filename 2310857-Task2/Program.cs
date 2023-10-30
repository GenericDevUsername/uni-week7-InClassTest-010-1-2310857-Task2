using System.Diagnostics.Metrics;

namespace _2310857_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Main Loop
            {
                // Take an input of only K, F or C. will not allow any other input
                Temperature temp = new Temperature();
                Console.Write("What measurement? (K, F or C):\n>>> ");
                char measurement = 'u';
                while (measurement == 'u')
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (Char.ToLower(key.KeyChar))
                    {
                        case 'k':
                            measurement = 'K';
                            break;

                        case 'f':
                            measurement = 'F';
                            break;

                        case 'c':
                            measurement = 'C';
                            break;
                    }
                }
                Console.Write($"{measurement}\n");

                // take temperature input
                double? temperature = null;
                while(temperature == null)
                {
                    Console.Write("What temperature?\n>>> ");
                    string input = Console.ReadLine();
                    try
                    {
                        temperature = Convert.ToDouble(input); // attept to convert temperature
                        break;
                    }
                    catch
                    {
                        // if not valid number output error
                        Console.WriteLine("Invalid Input!\n");
                    }
                }

                temp.Set(Convert.ToDouble(temperature), measurement); // set and auto convert temperature to to the users chosen input

                Console.WriteLine($"\nCelcius: {temp.Celcius}\nFahrenheit: {temp.Fahrenheit}\nKelvin: {temp.Kelvin}\n\n"); // print out temperatures

            }
        }
    }
}