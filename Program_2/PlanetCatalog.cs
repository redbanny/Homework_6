using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class PlanetCatalog
    {
        public List<Planet> Planets { get; set; }
        private int callCount {  get; set; }
        public PlanetCatalog() 
        {
            var venus = new Planet("Венера", 2, 38025, null);
            var earth = new Planet("Земля", 3, 40075, venus);
            var mars = new Planet("Марс", 4, 21326, earth);
            Planets = new List<Planet>() { venus, earth, mars };
            callCount = 0;
        }

        public (int? number, long? length, string? error) GetPlanet(string name)
        {
            callCount += 1;
            if (callCount % 3 != 0)
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
