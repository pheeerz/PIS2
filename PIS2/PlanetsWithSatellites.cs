using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    internal class PlanetsWithSatellites: Planets
    {
        public int counterOfSatellites {  get; set; }
        public PlanetsWithSatellites(string Name, DateTime OpeningDate, double Radius, int CounterOfSatellites) : base(Name, OpeningDate, Radius)
        {
            counterOfSatellites = CounterOfSatellites;
        }
    }
}
