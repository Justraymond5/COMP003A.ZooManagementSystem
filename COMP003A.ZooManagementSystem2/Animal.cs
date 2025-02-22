namespace COMP003A.ZooManagementSystem2;

internal abstract class Animal
{
    private string _name;
    private string _species;
    
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