namespace COMP003A.ZooManagementSystem2;

internal class ZooUtility 
{
    public static void DescribeAnimal(string name)
    {
        Console.WriteLine($"Name: {name}");
    }

    public static void DescribeAnimal(string name, string species)
    {
        Console.WriteLine($"Name: {name}, Species: {species}");
    }

    public static void DescribeAnimal(string name, string species, int age)
    {
        Console.WriteLine($"Name: {name}, Species: {species}, Age: {age}");
    }
}