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


            //string[] inputItems = Console.ReadLine().Split(' '); //для ввода через консоль

            string[] inputItems = test().Split(' '); // функция с вводными данными

            for (int i = 0; i < inputItems.Count(); i++)
            {
                inputItems[i] = inputItems[i].Replace("\"", "");
            }

            if (inputItems[0] == "Planets")
            {
                Planets planet = new Planets(inputItems);

                for (int x = 1; x < inputItems.Length - 2; x++)
                {
                    planet.Name += inputItems[x] + " ";
                }
                Console.WriteLine(planet.Name);
                Console.WriteLine(planet.OpeningDate);
                Console.WriteLine(planet.Radius);
            }

        }
        public static string test()
        {
            string input = "Planets \"Q W E   R TY\" 2024.01.01 13,1435";
            return input;

        }

    }
}
