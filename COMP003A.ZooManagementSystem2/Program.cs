namespace COMP003A.ZooManagementSystem2;
// Author: Raymond Gonzalez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
class Program
{
    static void Main(string[] args)
    {
        List <Animal> animals = new();
        Console.WriteLine("Welcome to the Zoo Management System!");
         while (true)
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");
                Console.Write("\nYour choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                if (choice == 1)
                {
                    Console.Write("Enter the name of the lion: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the species of the lion: ");
                    string species = Console.ReadLine();
                    animals.Add(new Lion(name, species));
                    
                    
                    Console.WriteLine("\nLion added successfully!");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the name of the parrot: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the species of the parrot: ");
                    string species = Console.ReadLine();
                    
                    animals.Add(new Parrot(name, species));
                    Console.WriteLine("\nParrot added successfully!");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nAnimals in the zoo:");
                    foreach (var animal in animals)
                    {
                        Console.WriteLine($"{animal.Name} ({animal.Species})");
                    }
                    
                }
                else if (choice == 4) // Describe an Animal
                {
                    Console.Write("Name of the animal you want to describe: ");
                    string Update = Console.ReadLine();

                    Animal UpdatedAnimal = null;
                    foreach (Animal animal in animals)
                    {
                        if (animal.Name.Equals(Update, StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                    }

                    if (UpdatedAnimal != null)
                    {
                        

                        
                    }
                    else
                    {
                        Console.WriteLine("Animal not found.");
                    }
                }

                else if (choice == 5)
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 5.");
                }
            }
        }
    }
