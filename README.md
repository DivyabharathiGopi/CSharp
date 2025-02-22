# CSharp
#Day 1 - 02/01/25 - HelloJan

#Day 2 - 03/01/25 - OddOrEven

#Day 3 - 06/01/25 - PerfectNumber

#Day 4 - 07/01/25 - AmicableNumber

     Okay! Imagine you have two numbers. Let's say they are A and B.

Now, proper divisors are just the numbers that can divide another number without leaving anything behind (and we don’t count the number itself). For example, the proper divisors of 6 are 1, 2, and 3. These are the numbers that divide 6, but 6 itself isn’t counted.

Here’s the cool part about amicable numbers: The proper divisors of A add up to B, and the proper divisors of B add up to A. So, if we add up all the proper divisors of A, we should get B, and if we add up all the proper divisors of B, we should get A.

Let’s look at an example:

Take 220 and 284  
- The proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110. If we add them up:  
  1 + 2 + 4 + 5 + 10 + 11 + 20 + 22 + 44 + 55 + 110 = 284.
  
- Now, the proper divisors of 284 are 1, 2, 4, 71, 142. If we add them up:  
  1 + 2 + 4 + 71 + 142 = 220.

Since the proper divisors of 220 add up to 284, and the proper divisors of 284 add up to 220, these numbers are amicable.

It’s like two friends, where each person gives the other a gift, and those gifts add up perfectly!

#Day 5 - 08/01/25 - RangeOfOddNumbers

       - Generates Odd Numbers within a Range.

#Day 6 - 09/01/25 -SwappingOfTwoNumbers

#Day 7 - 10/01/25 -SumOfDigits

#Day 8 - 11/01/25 -StringConcatination

#Day 9 - 12/01/25 - SumOfMultiples 

       - Sum of all 3 and 5 multiples below 100.

#Day 10 - 13/01/25 -Reverse a Number 

#Day 11 - 14/01/25 - Sum of N number

#Day 12 - 15/01/25 - Right Angle Traingle

#Day 13 - 16/01/25 - Absolute value or Double value 

#Day 14 - 17/01/25 - To check prime number or not

#Day 01 - 01/02/25 - QuizApp

     - Creating quiz app 
     - it will print question along with its choices
     - then it ask user to input answer between[1-4]
     - it will check if it is not then it will ask agin to input
     - if it is right it will increase the score
     - it will print the final score

#Day 02 - 02/02/25 - SimpleCalculator

     Addition Test:
     Input: 5, 3, +
     Expected Output:
     Enter the first number:
     Enter the second number:
     Choose an operation: +, -, *, /
     Result: 8
     Division by Zero Test:
     
     Input: 5, 0, /
     Expected Output:
     Enter the first number:
     Enter the second number:
     Choose an operation: +, -, *, /
     Error: Division by zero is not allowed.
     Invalid Operation Test:
     
     Input: 5, 3, %
     Expected Output:
     Enter the first number:
     Enter the second number:
     Choose an operation: +, -, *, /
     Invalid operation. Please choose +, -, *, or /.

#Day 03 - 03/03/25 - PrintRowSums

     Declare and initialize a 3x3 two-dimensional array with the following values:
     
     1 2 3
     4 5 6
     7 8 9
     
     - Calculate the sum of each row in the array.
     - Print the sum of each row to the console.
     
     result:
     6
     15
     24

#Day 04 - 04/02/25 - Calculate Average Temperature

     - Declare a method CalculateAverage that takes an array of doubles as a parameter.
     - Implement the method to calculate the average of the temperatures in the array.
     - Declare a method PrintAverage that takes an array of doubles as a parameter.
     - Implement the method to call CalculateAverage and print the result to the console.
     
     The result of execution for the default string should be:
     "The average temperature is: 23.5"

#Day 05 - 05/02/25 - Create a class with methods and properties

     - Declares a class Person with the following:
          - A private member variable _name of type string.
          - A public property Name with a getter and setter to access _name.
          - A private member variable _age of type int.
          - A public property Age with a getter and a custom setter that only sets _age if the value is greater than 0.
     - Adds a constructor to Person that takes two parameters, name and age, and initializes the member variables.
     - Adds a method Greet that prints a greeting message including the person's name and age.
     - Demonstrates the use of the class in the Main method by creating an instance of Person and calling the Greet method.
     
     The result of execution for the default string should be:
     "Hello, my name is John and I am 30 years old."

#Day 06 - 06/02/25 - QuestApp 

     - Quiz Console Application

#Day 07 - 07/02/25 - QuizApp

#Day 08 - 08/02/25 - PatternsPrograms

#Day 09 - 09/02/25 - SimpleList

     - Creating a simple list and iterating the list.

#Day 10 - 10/02/25 - AnyMethodOnList

     - Create a list of integers with values { 1, 6, 3 }. Use the Any method to check if any element in the list is greater than 5, and print "True" or "False" based on the result.
     - The result of execution for the default list should be: "True"

#Day 11 - 11/02/25 - PropertyListProgram

     - Create a class and properties - Product 
     - In the main class creating a list of product obj and adding the data.
     - Iteration over the list

#Day 12 - 12/02/25 - TryCatchFinally

     - Simple try, catch, finally keyword program.

#Day 13 - 13/02/25 - MultipleExceptions

     - Declare a method HandleMultipleExceptions which:
          - Takes a string  and an int as parameters, in that order.
     - Contains a local int[] variable with predefined elements, for example, int[] numbers = { 1, 2, 3 };.
     - Contains a try block where you:
     - Attempt to parse an integer from the string parameter that could throw a FormatException.
     - Access an element in the array by the integer parameter as an index that could throw an IndexOutOfRangeException.
     - Catch and handle both FormatException and IndexOutOfRangeException.
     - Print specific messages for each exception type.
     
     The result of execution should be:
     - If a FormatException occurs: "Invalid format."
     - If an IndexOutOfRangeException occurs: "Index out of range."
     - If no exception occurs: the accessed array element.
          - Example output for no exception: "2"
          - Example output for FormatException: "Invalid format."
          - Example output for IndexOutOfRangeException: "Index out of range."

#Day 14 - 14/02/25 - Inheritance

     - Define a base class Animal with a MakeSound method. Then, create a derived class Dog that overrides the MakeSound method. 
     - Use the base keyword to call the base class method within the derived class method. Print the sounds to the console.
     
     The result of execution should be:
     "Animal sound" "Dog barks"

#Day 14 - 14/02/25 - PropertyInheritance

     - Person Class:
          - Contains properties Name and Age that represent a person.
          - Has a constructor to initialize these properties and a method DisplayPersonInfo() to print them.
     - Employee Class:
          - Inherits from the Person class and adds an EmployeeId property.
          - Its constructor calls the base class constructor to initialize Name and Age and also sets the EmployeeId.
          - Contains a method DisplayEmployeeInfo() to display the EmployeeId and call the base class method DisplayPersonInfo() to display the Name and Age.

     - Output:
          - When an Employee object is created, it displays the EmployeeId, Name, and Age.
          - Example output for EmployeeId = 1, Name = "Divya", and Age = 23:

#Day 14 - 14/02/25 - SimpleInterface

     - Interface: IAnimal defines a contract for the MakeSound() and Eat() methods, which must be implemented by any class that uses the interface.
     - Polymorphism: By using the same method names (MakeSound() and Eat()), the program demonstrates polymorphism. Each class (Dog and Cat) provides its own implementation of these methods.
     - Object-Oriented Programming (OOP): The program uses classes, objects, and inheritance to organize the behavior of different animals in a clean and maintainable way.

#Day 15 - 15/02/25 - PaymentProcessingApp

     - This program demonstrates a **payment processing system** where different payment methods (Credit Card, PayPal, Bank Transfer) are handled through the **Dependency Injection (DI)** pattern. The `PaymentService` class delegates payment processing tasks to different processors that implement the `IPaymentProcessor` interface, allowing easy extension and flexibility. By using DI, new payment methods can be added without modifying the core `PaymentService` class, promoting scalability and maintainability.

#Day 16 - 16/02/25 - ConstructorDI

This program demonstrates a building process using two tools, **Hammer** and **Saw**, with **dependency injection**. The `BuildService` class receives these tools through its constructor and uses them to perform the building task. Each tool has a `Use` method to simulate its action (hammering and sawing). The program shows how to decouple the tool usage from the service, making the code flexible and easy to extend.

#Day 16 - 16/02/25 - SetterDI

This program demonstrates setter injection in dependency injection. It simulates a building process using two tools: Hammer and Saw. The BuildService class is injected with these tools through public properties (Hammer and Saw) after the object is created. The Build() method in BuildService uses both tools to perform actions (hammering nails and sawing wood), then prints "Build!" to indicate the completion of the task. This approach allows flexibility in providing the dependencies after object creation.

#Day 16 - 16/02/25 - InterfaceDI

This program uses **setter injection** to manage dependencies in the `BuildService` class. It injects a **Hammer** and **Saw** into `BuildService` using setter methods. The `Build()` method then simulates building by using these tools, printing actions like "Hammering nails" and "Sawing wood" to the console. This approach promotes flexibility and decoupling by allowing tools to be set after object creation.

#Day 17 - 17/02/25 - PropertyStruct

The program defines a `Point` struct with two properties, `X` and `Y`, representing the coordinates of a point. The struct includes a constructor that initializes these properties with specific values and a `Display` method to output the point's coordinates in the format "Point: X,Y". In the `Main` method, an instance of the `Point` struct is created with the coordinates (10, 20), and the `Display` method is called to print these coordinates to the console. The program demonstrates the use of structs, properties, constructors, and methods in C#.

#Day 17 - 17/02/25 - FiledStruct

FiledStruct Class:
This class contains the Main method, which is the starting point of the program.
It demonstrates the creation and manipulation of Point structs.

Point Struct:
The Point struct has two fields: X and Y, which represent the coordinates of the point.
A constructor is defined to initialize these fields when creating a Point object.
The Display method prints the X and Y values to the console.

Creating and Modifying Point Objects:
p1: An instance of Point is created with X=10 and Y=20. The Display method is called to show the coordinates.
p2: An uninitialized Point is created, and the X and Y values are set manually (X=30, Y=40). Then, the Display method is called to print p2's coordinates.
p3: A copy of p1 is created, and then the Y value of p3 is modified to 50. The modified p3 is displayed.

#Day 17 - 17/02/25 - DistanceBTWTwoPoints

Point Struct:
The Point struct contains two fields X and Y to represent a point in 2D space.
The constructor initializes these fields with provided values.

Distance Method:
The Distance method calculates the Euclidean distance between two points using the formula sqrt((x2 - x1)^2 + (y2 - y1)^2).

Display Method:
The Display method simply prints the coordinates of the point in the format Point: x, y.

Main Method:
Creates two points p1 and p2.
Displays their coordinates.
Calculates and displays the distance between p1 and p2.

#Day 17 - 17/02/25 - ValueAndReferenceType

Value Type (Struct) - Point:
Point is a struct, which is a value type in C#.
When p1 is assigned to p2, it copies the value of p1 into p2. Therefore, modifying p2 does not affect p1, since they are independent of each other.
After modifying p2.X = 60, p1 still holds its original value (10, 20) while p2 changes to (60, 20).

Reference Type (Class) - PointClass:
PointClass is a class, which is a reference type in C#.
When pc1 is assigned to pc2, both variables refer to the same object in memory. Thus, modifying pc2.X = 50 also changes the value of pc1, because both variables point to the same instance of PointClass.
After modifying pc2.X, both pc1 and pc2 now display (50, 40) because they are the same object in memory.

#Day 18 - 18/02/25 - DateTimeMath

Declare a struct Event with the following members:
- A DateTime field called StartDate.
- A DateTime field called EndDate.
- A method double GetDuration() that returns the duration of the event in days.
- A method bool IsOverlapping(Event otherEvent) that returns true if the event overlaps with another event.

Main class:
- Creates two Event instances with different start and end dates.
- Prints the duration of each event.
- Checks and prints whether the two events overlap.

The result of execution should be the duration of each event and whether they overlap printed to the console.
Example:

For an event starting on 2024-07-01 and ending on 2024-07-10, and another event starting on 2024-07-05 and ending on 2024-07-15, the output should be:

Event 1 Duration: 9 days
Event 2 Duration: 10 days
Events Overlap: True

#Day 19 = 19/02/25 - ReversingString

- Prompt for input: Asking the user to enter a string.
- Read input: Storing the user input in the variable str.
- Initialize reversed string: Preparing an empty string (reversedStr) to hold the reversed characters.
- Loop through string backwards: We start at the last index (str.Length - 1) and loop until the first index (0).
- Build the reversed string: During each iteration, the current character is appended to reversedStr.
- Print the reversed string: Finally, the reversed string is printed to the console.

#Day 20 - 21/02/25 - PalindromeString
