using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    internal class PlanetsWithAtmosphere: Planets
    {
        public bool atmosphere {  get; set; }
        public PlanetsWithAtmosphere(string Name, DateTime OpeningDate, double Radius, bool Atmosphere): base(Name, OpeningDate, Radius) 
        {
            atmosphere = Atmosphere;
        }
    }
}
