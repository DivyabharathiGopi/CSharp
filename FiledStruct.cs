using System;

public class FiledStruct
{
    // Main method - entry point of the program
    public static void Main(string[] args)
    {
        // Creating an instance of Point with X=10 and Y=20
        Point p1 = new Point(10, 20);
        // Displaying the coordinates of p1
        p1.Display();
        
        // Creating an uninitialized instance of Point
        Point p2;
        // Setting the X coordinate of p2 to 30
        p2.X = 30;
        // Setting the Y coordinate of p2 to 40
        p2.Y = 40;
        // Displaying the coordinates of p2
        p2.Display();
        
        // Creating a new Point p3 by copying the values of p1
        Point p3 = p1;
        // Modifying the Y coordinate of p3 to 50
        p3.Y = 50;
        // Displaying the modified coordinates of p3
        p3.Display();
    }
}

public struct Point
{
    // Declaring the X coordinate as a public field
    public int X;
    // Declaring the Y coordinate as a public field
    public int Y;
    
    // Constructor to initialize a Point object with specific X and Y values
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    // Method to display the X and Y coordinates of the Point
    public void Display()
    {
        // Printing the coordinates of the current point in the format "Point: X,Y"
        Console.WriteLine($"Point:{X},{Y}");
    }
}
