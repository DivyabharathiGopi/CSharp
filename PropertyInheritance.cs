using System;

public class PropertyInheritance
{
    public static void Main(string[] args)
    {
        // Create an object of the derived class 'Employee' with parameters for EmployeeId, Name, and Age
        Employee divya = new Employee(1, "Divya", 23);
        
        // Calling the derived class method DisplayEmployeeInfo to display EmployeeId, Name, and Age
        divya.DisplayEmployeeInfo();
        
        Console.ReadKey();
    }
}

public class Person
{
    // Base class properties for storing the Name and Age of a person
    public string Name { get; private set; }  // Property for storing the person's name
    public int Age { get; private set; }      // Property for storing the person's age
    
    // Base class constructor to initialize the Name and Age properties
    public Person(string name, int age)
    {
        Name = name;  // Assign the provided name to the Name property
        Age = age;    // Assign the provided age to the Age property
    }
    
    // Base class method to display the Name and Age of a person
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");  // Output the person's name and age
    }
}

public class Employee : Person
{
    // Additional property for EmployeeId specific to the Employee class
    public int EmployeeId { get; private set; }  // Property to store the EmployeeId
    
    // Constructor for Employee class, calling the base class constructor to initialize Name and Age
    // It also initializes EmployeeId with the provided id
    public Employee(int id, string name, int age) : base(name, age)
    {
        EmployeeId = id;  // Assign the provided id to the EmployeeId property
    }

    // Method in the derived class to display EmployeeId and call the base class method to display Name and Age
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Employee Id: " + EmployeeId);  // Display the EmployeeId
        DisplayPersonInfo();  // Call the base class method to display Name and Age
    }
}
