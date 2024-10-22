using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название класса и его свойства");
            string[] inputItems = "Planets \"Q W E   R TY\" 2024.01.01 13,1435".Split(' ');

            if (inputItems[0] == "Planets")
            {
                Planets planets = TEST(inputItems);
                Console.WriteLine(planets.name);
                Console.WriteLine(planets.openingDate);
                Console.WriteLine(planets.radius);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        private static Planets TEST(string[] inputItems)
        {
            inputItems = ToCorrectString(inputItems);

            string Name = "";
            DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 2]);
            double Radius = Convert.ToDouble(inputItems[inputItems.Length - 1]);

            for (int x = 1; x < inputItems.Length - 2; x++)
            {
                Name += inputItems[x] + " ";
            }

            return new Planets(Name, OpeningDate, Radius);
        }

        private static string[] ToCorrectString(string[] inputItems)
        {
            for (int i = 0; i < inputItems.Count(); i++)
            {
                inputItems[i] = inputItems[i].Replace("\"", "");
            }
            return inputItems;
        }
    }
}
