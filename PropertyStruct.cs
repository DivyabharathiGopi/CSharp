using System;

public class PropertyStruct
{
    // Main entry point of the program
    public static void Main(string[] args)
    {
        // Creating an instance of Point with X=10 and Y=20
        Point p1 = new Point(10, 20);

        // Calling the Display method to print the point values
        p1.Display();
    }
}

public struct Point
{
    // Property for the X-coordinate. Automatically generates a getter and setter
    public int X { get; set; }

    // Property for the Y-coordinate. Automatically generates a getter and setter
    public int Y { get; set; }

    // Constructor to initialize a Point with specified X and Y values
    public Point(int x, int y)
    {
        // Initializing X and Y with the provided values
        X = x;
        Y = y;
    }

    // Method to display the values of X and Y in the format "Point: X,Y"
    public void Display()
    {
        // Printing the X and Y values to the console
        Console.WriteLine($"Point: {X},{Y}");
    }
}
