using System;

public class PropertyInheritance
{
    public static void Main(string[] args)
    {
        // Create an object of the derived class 'Employee' with parameters for EmployeeId, Name, and Age
        Employee divya = new Employee(1, "Divya", 23);
        
        // Calling the base class method (DisplayInfo) from the derived class to display Name and Age
        divya.DisplayInfo();
        
        Console.ReadKey();
    }
}

public class Person
{
    // Base class properties for storing the Name and Age of a person
    public string Name { get; private set; }
    public int Age { get; private set; }
    
    // Base class constructor to initialize the Name and Age properties
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    // Base class method to display the Name and Age of a person
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Employee : Person
{
    // Additional property for EmployeeId specific to the Employee class
    public int EmployeeId { get; set; }

    // Constructor for Employee class, calling the base class constructor to initialize Name and Age
    // It also initializes EmployeeId and prints it to the console
    public Employee(int id, string name, int age) : base(name, age)
    {
        EmployeeId = id;
        Console.WriteLine("Employee Id: " + EmployeeId);  // Display the EmployeeId when the object is created
    }
}
