using System;

public class ConstructorDI
{
    // Main entry point for the program
    public static void Main(string[] args)
    {
        // Create instances of Hammer and Saw
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        
        // Create a BuildService and inject the Hammer and Saw objects into it
        BuildService buildService = new BuildService(hammer, saw);
        
        // Call the Build method which uses the Hammer and Saw to perform the build
        buildService.Build();
    }
}

// The Hammer class simulates a hammer that is used to hammer nails
public class Hammer
{
    // Method to simulate the action of using the hammer
    public void Use()
    {
        Console.WriteLine("Hammering nails");
    }
}

// The Saw class simulates a saw that is used to saw wood
public class Saw
{
    // Method to simulate the action of using the saw
    public void Use()
    {
        Console.WriteLine("Sawing wood");
    }
}

// The BuildService class is responsible for using tools to build something
public class BuildService
{
    // Private fields to hold the hammer and saw
    private Hammer _hammer;
    private Saw _saw;
    
    // Constructor that accepts Hammer and Saw objects and injects them into the class
    public BuildService(Hammer hammer, Saw saw)
    {
        _hammer = hammer; // Assign hammer to the private field
        _saw = saw; // Assign saw to the private field
    }
    
    // Method that performs the building process using the tools (Hammer and Saw)
    public void Build()
    {
        // Use the hammer to perform the action of hammering nails
        _hammer.Use();
        
        // Use the saw to perform the action of sawing wood
        _saw.Use();
        
        // Output that the building is complete
        Console.WriteLine("Build!");
    }
}
