using Program_2;

string[] names = new string[] { "Земля", "Лимония", "Марс" };
var catalogPlanet = new PlanetCatalog();
foreach (string name in names)
{
    var planet = catalogPlanet.GetPlanet(name);
    if (planet.error != null)
        Console.WriteLine(planet.error);
    else
        Console.WriteLine($"Планета: {name}, Порядковый номер: {planet.number}, Длина экватора: {planet.length}");
}
