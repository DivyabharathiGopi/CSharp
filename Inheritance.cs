using System;

public class Inheritance
{
    public static void Main(string[] args)
    {
        // TODO: Create an instance of Dog and call the MakeSound method
            Dog myDog = new Dog();
            myDog.MakeSound();
    }
public class Animal
    {
        // TODO: Declare a virtual method MakeSound
        public virtual void  MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

public class Dog : Animal
    {
        // TODO: Override the MakeSound method
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }
}
