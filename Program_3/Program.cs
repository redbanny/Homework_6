using Program_3;

var catalogPlanet = new PlanetCatalog();
var counter = 0;
string[] names = new string[] { "Земля", "Лимония", "Марс" };
foreach (var name in names)
{
    var planet = catalogPlanet.GetPlanet(name, i =>
    {
        counter++;
        if (counter % 3 != 0)
            return null;
        else
            return "Вы спрашиваете слишком часто";
    });
    if (planet.error != null)
        Console.WriteLine(planet.error);
    else
        Console.WriteLine($"Планета: {name}, Порядковый номер: {planet.number}, Длина экватора: {planet.length}");
}
