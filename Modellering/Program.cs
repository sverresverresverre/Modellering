Soap theSoap = new Soap();
Sweat theSweat = new Sweat();

Console.WriteLine($"{theSoap.name} has {theSoap.attack} attack power");
Console.WriteLine($"{theSweat.name} has {theSweat.health} health points");

// Console.WriteLine("ATTACK!");
// theSweat.health -= 10;

// Console.WriteLine($"{theSweat.name} now has {theSweat.health} health");

// Console.WriteLine("Press any key to continue...");
// Console.ReadKey();

while (theSweat.health > 0)
{
    Console.WriteLine("\nWrite attack to damage Sweat");
    
    string damage = Console.ReadLine();
    
    if (damage == "attack")
    {
        theSweat.health -= theSoap.attack;
    }

    Console.WriteLine($"{theSweat.name} now has {theSweat.health} health points");

    Console.WriteLine("Press any key to continue");

    Console.ReadKey();
}

Console.WriteLine("\nCongratulations, the Sweat is now gone");
Console.WriteLine("Press any key to close");
Console.ReadKey();
