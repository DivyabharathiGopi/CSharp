using System;

public class ValueAndReferenceType
{
    public static void Main(string[] args)
    {
        // Demonstrating value type behavior (using a struct)
        Console.WriteLine("Value Type:");
        
        // Creating a Point struct with coordinates (10, 20)
        Point p1 = new Point(10, 20);
        
        // Assigning p1 to p2. Since Point is a struct (value type), a copy of p1 is created for p2.
        Point p2 = p1;

        // Displaying the values of p1 and p2 (both should show 10, 20 initially)
        p1.Display();
        p2.Display();

        // Changing p2's X value (this does not affect p1 because structs are value types)
        Console.WriteLine("After:");
        p2.X = 60;

        // Displaying the updated values of p1 and p2
        p1.Display();  // p1 remains (10, 20)
        p2.Display();  // p2 is now (60, 20) because it was a copy of p1 initially

        Console.WriteLine(); // Empty line for better readability

        // Demonstrating reference type behavior (using a class)
        Console.WriteLine("Reference Type:");

        // Creating a PointClass object with coordinates (30, 40)
        PointClass pc1 = new PointClass(30, 40);

        // Assigning pc1 to pc2. Since PointClass is a class (reference type), pc1 and pc2 now refer to the same object.
        PointClass pc2 = pc1;

        // Displaying the values of pc1 and pc2 (both should show 30, 40 initially)
        pc1.Display();
        pc2.Display();

        // Changing pc2's X value (this also affects pc1 because they refer to the same object)
        Console.WriteLine("After:");
        pc2.X = 50;

        // Displaying the updated values of pc1 and pc2 (both will be affected because they refer to the same instance)
        pc1.Display();  // pc1's values are now (50, 40) because it is the same object as pc2
        pc2.Display();  // pc2 is also (50, 40), the same as pc1 because they reference the same object

        Console.ReadKey(); // Waiting for user input to close the console window
    }
}

// Definition of Point struct (value type)
public struct Point
{
    // X and Y are the coordinates of the Point
    public int X;
    public int Y;

    // Constructor to initialize the Point struct with X and Y values
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the coordinates of the Point
    public void Display()
    {
        Console.WriteLine($"Point: {X}, {Y}");  // Output the X and Y values of the point
    }
}

// Definition of PointClass class (reference type)
public class PointClass
{
    // X and Y are the coordinates of the PointClass
    public int X;
    public int Y;

    // Constructor to initialize the PointClass with X and Y values
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the coordinates of the PointClass
    public void Display()
    {
        Console.WriteLine($"Point: {X}, {Y}");  // Output the X and Y values of the point
    }
}
