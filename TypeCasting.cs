using System;

namespace dark{
	
	internal class Employee{
		string name;
	}

  internal class Manager : Employee{
    string managerPosition;
  }

  public sealed class Program{
    // Correct declration should have been 
    // private static void PromoteEmployee(Employee o){
    private static void PromoteEmployee(Object o){
        // At this point the compiler doesnt know exactly what type of object
        // "o" refers to so it allows to compile.But at runtime, CLR checks for the type of o everytime it is 
        // typecasted, to check whether o is of Employee Type or any of its subtype.
      Employee e = (Employee) o;
    }

    public static void Main(){
      // Cast to any base type are implicitly safe
      Object o = new Employee();

      // Employee e = o; Cast to any derived type are not implicitly safe, thus compile error
      Employee e = (Employee) o;  // Explicit Type Casting, but this too can fail at runtime!
      Console.WriteLine("Type-Casting + Type-Safety");
      PromoteEmployee(e);
      DateTime newYears = new DateTime(2013, 1, 1);

      PromoteEmployee(newYears); // this will result in InvalidCastException.


      // Using "is" and "as" operator 
      Object o2 = new Object();
      Boolean b1 = (o is Object);   // True
      Boolean b2 = (o is Employee); // False

      // "as" operator returns null, if the object is not compatible and cannot be typecasted to EmployeeType
      Employee e2 = o as Employee;
      if(e2 != null){
        Console.WriteLine("Object refered by 'o' is compatible to Emplyee type and now has been typecasted");
      }  

    }
  }	
}