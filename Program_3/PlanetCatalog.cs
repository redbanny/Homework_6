using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3
{
    internal class PlanetCatalog
    {
        public List<Planet> Planets { get; set; }

        public delegate string PlanetValidator(string? i);
        public PlanetCatalog()
        {
            var venus = new Planet("Венера", 2, 38025, null);
            var earth = new Planet("Земля", 3, 40075, venus);
            var mars = new Planet("Марс", 4, 21326, earth);
            Planets = new List<Planet>() { venus, earth, mars };
        }

        public (int? number, long? length, string? error) GetPlanet(string name, PlanetValidator vPlanet)
        {
            var validPlanet = vPlanet(name);
            if (string.IsNullOrEmpty(validPlanet))
            {
                Planet planet = Planets.FirstOrDefault(x => x.PlanetName == name);
                if (planet == null)
                    return (null, null, "Планета не найдена");
                else
                    return (planet.PlanetNumber, planet.PlanetLength, null);
            }
            else
                return (null, null, "Вы спрашиваете слишком часто");
        }

    }
}
