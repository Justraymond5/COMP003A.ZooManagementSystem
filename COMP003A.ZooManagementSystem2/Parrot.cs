namespace COMP003A.ZooManagementSystem2;
/// <summary>
/// Lion herites data from animal class.
/// </summary>
class Parrot : Animal
{
    public Parrot( string name, string species) : base(name, species)
    {
        Name = name;
        Species = species;
    }
    public override void MakeSound()
    {
        Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
    }
    
    
    
}