var planet1 = new { Name = "Венера", Number = 2, Length = 38025 };
var planet2 = new { Name = "Земля", Number = 3, Length = 40075, Previous = planet1 };
var planet3 = new { Name = "Марс", Number = 4, Length = 21326, Previous = planet2 };
var planet4 = new { Name = "Венера", Number = 2, Length = 38025 };

Console.WriteLine($"{planet1.Name}: {planet1.Number}," +
    $" {planet1.Length}. Венера?: {planet1.Equals(planet1)}");

Console.WriteLine($"{planet2.Name}: {planet2.Number}," +
    $" {planet2.Length}, {planet2.Previous.Name}. Венера?: {planet2.Equals(planet1)}");

Console.WriteLine($"{planet3.Name}: {planet3.Number}," +
    $" {planet3.Length}, {planet3.Previous.Name}. Венера?: {planet3.Equals(planet1)}");

Console.WriteLine($"{planet4.Name}: {planet4.Number}," +
    $" {planet4.Length}. Венера?: {planet4.Equals(planet1)}");
