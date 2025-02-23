namespace COMP003A.ZooManagementSystem2;
/// <summary>
/// method overloading 
/// </summary>
internal class ZooUtility 
{
    /// <summary>
    /// Animal name
    /// </summary>
    
    public static void DescribeAnimal(string name)
    {
        Console.WriteLine($"Name: {name}");
    }
    /// <summary>
    /// Animal name and species
    /// </summary>
    public static void DescribeAnimal(string name, string species)
    {
        Console.WriteLine($"Name: {name}, Species: {species}");
    }
    /// <summary>
    /// Animal name, species, and age
    /// </summary>

    public static void DescribeAnimal(string name, string species, int age)
    {
        Console.WriteLine($"Name: {name}, Species: {species}, Age: {age}");
    }
}