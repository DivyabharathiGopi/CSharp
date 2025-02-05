using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO
            Person personInstance = new Person("John",30);
            personInstance.Greet();
        }
    }

    public class Person
    {
        // TODO
        private string _name;
        private int _age;
        
        public string Name {
            get{
                return _name;
               } 
            set{
                _name= value;
                }
        }
        
        public int Age {
            get{
                return _age;
            }
            set{
                if (value > 0)
                {
                    _age = value;  // Only set _age if the value is greater than 0
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }
            }
        }
        
        //consructor
        public Person(string name, int age)
        {
            Name=name;
            Age=age;
        }
        
        //method
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
