using System;

public class DistanceBTWTwoPoints
{
    public static void Main(string[] args)
    {
        // Creating two points, p1 and p2, with specific coordinates
        Point p1 = new Point(10, 20);  // Point p1 at (10, 20)
        Point p2 = new Point(30, 40);  // Point p2 at (30, 40)
        
        // Display the coordinates of the points p1 and p2
        p1.Display();  // Calls Display method to print p1's coordinates
        p2.Display();  // Calls Display method to print p2's coordinates
        
        // Calculate the distance between p1 and p2
        double distance1 = p1.Distance(p2);  // Calls the Distance method for p1 and p2
        
        // Print the calculated distance between p1 and p2
        Console.WriteLine($"Distance between two points: {distance1}");

        // The following code is commented out but can also be used to calculate distance in reverse
        //double distance2 = p2.Distance(p1);  // Calls the Distance method for p2 and p1
        //Console.WriteLine($"Distance between two points: {distance2}");
    }
}

public struct Point
{
    // X and Y are the coordinates of the point
    public int X;  
    public int Y;
    
    // Constructor to initialize the point with X and Y values
    public Point(int x, int y)
    {
        X = x;  // Initialize X coordinate
        Y = y;  // Initialize Y coordinate
    }
    
    // Method to display the coordinates of the point
    public void Display()
    {
        Console.WriteLine($"Point: {X}, {Y}");  // Prints the X and Y values
    }
    
    // Method to calculate the distance between this point and another point
    public double Distance(Point other)
    {
        int dx = other.X - this.X;  // Difference in X coordinates
        int dy = other.Y - this.Y;  // Difference in Y coordinates
        
        // Calculate and return the distance using the Euclidean distance formula
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
