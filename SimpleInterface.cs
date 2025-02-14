using System;

public class SimpleInterface
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Create a Dog object and call its methods
        Dog dog = new Dog();
        dog.MakeSound();  // Calls the method to make the sound of a dog
        dog.Eat("Treats");  // Calls the method to simulate the dog eating a treat
        
        // Create a Cat object and call its methods
        Cat cat = new Cat();
        cat.MakeSound();  // Calls the method to make the sound of a cat
        cat.Eat("Milk");  // Calls the method to simulate the cat drinking milk
    }
}

// Interface definition for animals
interface IAnimal
{
    // Method signature for making a sound, to be implemented by the classes
    void MakeSound();  

    // Method signature for eating, which accepts a string parameter (food)
    void Eat(string food);  
}

// Dog class implementing the IAnimal interface
public class Dog : IAnimal
{
    // Implementation of MakeSound method for Dog
    public void MakeSound()
    {
        Console.WriteLine("Bark");  // Prints the sound a dog makes
    }

    // Implementation of Eat method for Dog
    public void Eat(string food)
    {
        Console.WriteLine("Dog ate " + food);  // Prints what the dog ate
    }
}

// Cat class implementing the IAnimal interface
public class Cat : IAnimal
{
    // Implementation of MakeSound method for Cat
    public void MakeSound()
    {
        Console.WriteLine("Meowing");  // Prints the sound a cat makes
    }

    // Implementation of Eat method for Cat
    public void Eat(string food)
    {
        Console.WriteLine("Cat drank " + food);  // Prints what the cat drank
    }
}
