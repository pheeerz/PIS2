using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace PIS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название класса и его свойства");

            //string[] inputItems = ToCorrectString("Planets \"Q W E   R TY\" 2024.01.01 13,1435");

            string[] inputItems = File.ReadAllText("../../Test.txt").Split(' ');

            if (inputItems[0] == "Planets")
            {
                Planets planets = ToPlanets(inputItems);
                Console.WriteLine(planets.name);
                Console.WriteLine(planets.openingDate);
                Console.WriteLine(planets.radius);

                PlanetsWithAtmosphere atmos = ToWithAtmosphere(inputItems);
                PlanetsWithSatellites satellites = ToWithSatellites(inputItems);

                Console.WriteLine($"\nАтмосфера: {atmos.atmosphere}\n");
                Console.WriteLine($"Кол-во спутников: {satellites.counterOfSatellites}\n");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        private static PlanetsWithSatellites ToWithSatellites(string[] inputItems)
        {
            string Name = "";
            DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 2]);
            double Radius = Convert.ToDouble(inputItems[inputItems.Length - 1]);

            for (int x = 1; x < inputItems.Length - 2; x++)
            {
                Name += inputItems[x] + " ";
            }
            Console.WriteLine("Сколько у этой планеты спутников?");
            int CounterOfSatellites = Convert.ToInt32(Console.ReadLine());

            return new PlanetsWithSatellites(Name, OpeningDate, Radius, CounterOfSatellites);
        }

        private static PlanetsWithAtmosphere ToWithAtmosphere(string[] inputItems)
        {
            string Name = "";
            DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 2]);
            double Radius = Convert.ToDouble(inputItems[inputItems.Length - 1]);

            for (int x = 1; x < inputItems.Length - 2; x++)
            {
                Name += inputItems[x] + " ";
            }
            Console.WriteLine("У этой планеты есть атмосфера? (+/-)");
            string atmos = Console.ReadLine();
            bool Atmosphere = false;
            if (atmos == "+")
            {
                Atmosphere = true;
            }
            return new PlanetsWithAtmosphere(Name, OpeningDate, Radius, Atmosphere);
        }
        private static Planets ToPlanets(string[] inputItems)
        {
            string Name = "";
            DateTime OpeningDate = Convert.ToDateTime(inputItems[inputItems.Length - 2]);
            double Radius = Convert.ToDouble(inputItems[inputItems.Length - 1]);

            for (int x = 1; x < inputItems.Length - 2; x++)
            {
                Name += inputItems[x] + " ";
            }

            return new Planets(Name, OpeningDate, Radius);
        }

        // Нужен, если строка подается не с консоли
        private static string[] ToCorrectString(string inputItem)
        {
            string[] inputItems = inputItem.Split(' ');
            for (int i = 0; i < inputItems.Count(); i++)
            {
                inputItems[i] = inputItems[i].Replace("\"", "");
            }
            return inputItems;
        }
    }
}
