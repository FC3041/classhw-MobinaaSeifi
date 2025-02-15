using System;
using System.Collections.Generic;

namespace part8;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            double input;

            Console.WriteLine("Enter numbers (type -1 to finish):");

            
            while (true)
            {
                input = Convert.ToDouble(Console.ReadLine());
                if (input == -1)
                    break;
                numbers.Add(input);
            }

           
            if (numbers.Count > 0)
            {
                double sum = 0;
                double min = numbers[0];
                double max = numbers[0];

                foreach (double number in numbers)
                {
                    sum += number;
                    if (number < min)
                        min = number;
                    if (number > max)
                        max = number;
                }

                double average = sum / numbers.Count;

                Console.WriteLine($"Number of entries: {numbers.Count}");
                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Minimum: {min}");
                Console.WriteLine($"Maximum: {max}");
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
        }
    }

    //از هوش مصنوعی برای حل این سوال استفاده کردم چون کامل تدریس نشده بود و مشکل داشتم

