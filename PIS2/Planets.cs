using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    internal class Planets
    {
        public string name { get; set; }
        public DateTime openingDate { get; set; }
        public double radius { get; set; }

        public Planets(string Name, DateTime OpeningDate, double Radius)
        {
            name = Name;
            openingDate = OpeningDate;
            radius = Radius;
        }
    }
}
