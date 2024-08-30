Soap theSoap = new Soap();
Sweat theSweat = new Sweat();

Console.WriteLine($"{theSoap.name} has {theSoap.health} HP");
Console.WriteLine($"{theSweat.name} has {theSweat.health} HP and size {theSweat.size}");

Console.WriteLine("ATTACK!");
theSweat.health -= 10;

Console.WriteLine($"{theSweat.name} now has {theSweat.health} health");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
