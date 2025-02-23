namespace COMP003A.ZooManagementSystem2;
/// <summary>
/// parrot herites data from animal class.
/// </summary>
class Parrot : Animal
{
    public Parrot( string name, string species) : base(name, species)
    {
        
    }
    /// <summary>
    /// Prints the sound of parrot
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
    }
    
    
    
}