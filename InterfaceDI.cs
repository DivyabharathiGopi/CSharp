using System;

public class InterfaceDI
{
    // Main method: Entry point of the program
    public static void Main(string[] args)
    {
        // Creating instances of Hammer and Saw
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        
        // Creating an instance of BuildService
        BuildService buildService = new BuildService();
        
        // Injecting dependencies (Hammer and Saw) into BuildService using setter methods
        buildService.SetHammer(hammer);
        buildService.SetSaw(saw);
        
        // Calling the Build method to perform the building process
        buildService.Build();
    }
}

// IToolUser interface defines the setter methods for injecting the tools into BuildService
public interface IToolUser
{
    // Method to set the Hammer tool
    void SetHammer(Hammer hammer);
    
    // Method to set the Saw tool
    void SetSaw(Saw saw);
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

// BuildService class implements IToolUser interface and is responsible for using the tools to perform the build
public class BuildService : IToolUser
{
    // Private fields to store Hammer and Saw tools
    private Hammer _hammer;
    private Saw _saw;
    
    // Setter method to inject the Hammer tool
    public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }
    
    // Setter method to inject the Saw tool
    public void SetSaw(Saw saw)
    {
        _saw = saw;
    }
    
    // Method that uses the Hammer and Saw to perform the building task
    public void Build()
    {
        // Using the Hammer to hammer nails
        _hammer.Use();
        
        // Using the Saw to saw wood
        _saw.Use();
        
        // Printing that the build is complete
        Console.WriteLine("Build!");
    }
}
