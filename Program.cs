// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Operator Overloading Example
// This program tests the overloaded == and != operators in the Employee class

// Main method
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Operator Overloading Example");
        Console.WriteLine("---------------------------");
        
        // Create two Employee objects and assign values to their properties
        Employee employee1 = new Employee(1, "John", "Smith");
        Employee employee2 = new Employee(2, "Michael", "Johnson");
        Employee employee3 = new Employee(1, "Emily", "Davis"); // Same Id as employee1
        
        // Display employee information
        Console.WriteLine("\nEmployee Information:");
        Console.WriteLine($"Employee 1: {employee1}");
        Console.WriteLine($"Employee 2: {employee2}");
        Console.WriteLine($"Employee 3: {employee3}");
        
        // Compare using == operator
        Console.WriteLine("\n== Operator Comparison Results:");
        Console.WriteLine($"employee1 == employee2: {employee1 == employee2}"); // Should be false (different Ids)
        Console.WriteLine($"employee1 == employee3: {employee1 == employee3}"); // Should be true (same Ids)
        
        // Compare using != operator
        Console.WriteLine("\n!= Operator Comparison Results:");
        Console.WriteLine($"employee1 != employee2: {employee1 != employee2}"); // Should be true (different Ids)
        Console.WriteLine($"employee1 != employee3: {employee1 != employee3}"); // Should be false (same Ids)
        
        // Compare using Equals method
        Console.WriteLine("\nEquals Method Comparison Results:");
        Console.WriteLine($"employee1.Equals(employee2): {employee1.Equals(employee2)}"); // Should be false
        Console.WriteLine($"employee1.Equals(employee3): {employee1.Equals(employee3)}"); // Should be true
        
        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
