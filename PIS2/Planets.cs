using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    internal class Planets
    {
        public string Name { get; set; }
        public DateTime OpeningDate { get; set; }
        public double Radius { get; set; }

        public Planets(string[] items)
        {
            string name = "";
            DateTime openingDate = Convert.ToDateTime(items[items.Length - 2]);
            double radius = Convert.ToDouble(items[items.Length - 1]);
            Name = name;
            OpeningDate = openingDate;
            Radius = radius;

        }
    }
}
