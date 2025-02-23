namespace COMP003A.ZooManagementSystem2;

/// <summary>
/// Abstract class
/// </summary>
 abstract class Animal
{
    private string _name;
    private string _species;
    
    
    /// <summary>
    ///  Gets and sets the name of the animal
    /// </summary>
    /// <exception cref="ArgumentException">Cant be empty</exception>
    public string Name
    {
        get
        {return _name;
        }
        set
        {
            
            
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("You need a name to proceed.");
                }
                _name = value;
            
        }
    }
/// <summary>
///  Gets and sets the species of the animal
/// </summary>
/// <exception cref="ArgumentException">Cant be empty</exception>
    public string Species
    {
        get
        {return _species;
        }
        set
        {
            
            
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("You need a name to proceed.");
            }
            _species = value;
            
        }
        
    }
    // El Constructor
    public Animal(string name, string species)
    {
        Name = name;
        Species = species;
    }
    public abstract void MakeSound();
}