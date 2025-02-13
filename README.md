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
