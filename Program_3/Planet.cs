using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    class Planet
    {
        public Planet(string name, int number, int lenght, Planet? planet)
        {
            PlanetName = name;
            PlanetNumber = number;
            PlanetLength = lenght;
            PreviousPlanet = planet;
        }

        public string PlanetName { get; set; } = null!;
        public int PlanetNumber { get; set; }
        public long PlanetLength { get; set; }
        public Planet? PreviousPlanet { get; set; }
    }
}
