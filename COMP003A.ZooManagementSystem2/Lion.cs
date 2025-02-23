namespace COMP003A.ZooManagementSystem2;
/// <summary>
/// Lion herites data from animal class.
/// </summary>
class Lion : Animal
{
    public Lion( string name, string species) : base(name, species)
    {
       
    }
    /// <summary>
    /// Prints the sound of lion
    /// </summary>
    public override void MakeSound()
    {
        Console.WriteLine($"The lion roars! ({Name}, {Species})");
    }
    
    
    
}