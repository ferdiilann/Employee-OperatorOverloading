using System;

/// <summary>
/// Employee class represents the basic information of an employee.
/// </summary>
public class Employee
{
    /// <summary>
    /// Unique identifier of the employee
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// First name of the employee
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Last name of the employee
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Default constructor
    /// </summary>
    public Employee()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    
    /// <summary>
    /// Parameterized constructor
    /// </summary>
    /// <param name="id">Employee ID</param>
    /// <param name="firstName">Employee first name</param>
    /// <param name="lastName">Employee last name</param>
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    
    /// <summary>
    /// Overloading the == operator
    /// Compares the Id properties of two Employee objects
    /// </summary>
    /// <param name="employee1">First employee</param>
    /// <param name="employee2">Second employee</param>
    /// <returns>Returns true if Ids are equal, otherwise false</returns>
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Null check
        if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            return true;
            
        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            return false;
            
        // Compare Id properties
        return employee1.Id == employee2.Id;
    }
    
    /// <summary>
    /// Overloading the != operator (must be overloaded in pair with == operator)
    /// Checks if the Id properties of two Employee objects are not equal
    /// </summary>
    /// <param name="employee1">First employee</param>
    /// <param name="employee2">Second employee</param>
    /// <returns>Returns true if Ids are not equal, otherwise false</returns>
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Return the opposite of == operator
        return !(employee1 == employee2);
    }
    
    /// <summary>
    /// Override of Object.Equals method
    /// </summary>
    /// <param name="obj">Object to compare</param>
    /// <returns>Returns true if objects are equal, otherwise false</returns>
    public override bool Equals(object obj)
    {
        // Return false if parameter is null or different type
        if (obj == null || GetType() != obj.GetType())
            return false;
            
        // Cast parameter to Employee type and compare Ids
        Employee other = (Employee)obj;
        return Id == other.Id;
    }
    
    /// <summary>
    /// Override of Object.GetHashCode method
    /// </summary>
    /// <returns>Returns the hash code of the object</returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    
    /// <summary>
    /// Returns employee information as a string
    /// </summary>
    /// <returns>String containing employee information</returns>
    public override string ToString()
    {
        return $"Id: {Id}, First Name: {FirstName}, Last Name: {LastName}";
    }
} 