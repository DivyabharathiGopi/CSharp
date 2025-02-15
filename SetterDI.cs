using System;

public class SetterDI
{
    // Main entry point for the program
    public static void Main(string[] args)
    {
        // Creating instances of Hammer and Saw tools
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        
        // Creating an instance of BuildService
        BuildService buildService = new BuildService();
        
        // Injecting the Hammer and Saw objects into the BuildService using setter injection
        buildService.Hammer = hammer;
        buildService.Saw = saw;
        
        // Calling the Build method to perform the building action
        buildService.Build();
    }
}

// Hammer class simulates the action of hammering nails
public class Hammer
{
    // Method to simulate using the hammer
    public void Use()
    {
        Console.WriteLine("Hammering nails");
    }
}

// Saw class simulates the action of sawing wood
public class Saw
{
    // Method to simulate using the saw
    public void Use()
    {
        Console.WriteLine("Sawing wood");
    }
}

// BuildService class is responsible for using the Hammer and Saw tools to perform a build
public class BuildService
{
    // Public properties for Hammer and Saw, allowing their values to be set using setters
    public Hammer Hammer { get; set; }
    public Saw Saw { get; set; }
    
    // Method that uses the Hammer and Saw to perform the building task
    public void Build()
    {
        // Using the Hammer to hammer nails
        Hammer.Use();
        
        // Using the Saw to saw wood
        Saw.Use();
        
        // Printing that the build is complete
        Console.WriteLine("Build!");
    }
}
