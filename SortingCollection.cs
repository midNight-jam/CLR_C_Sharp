using System;
using System.Collections.Generic;
namespace dark{
  
  public sealed class SortingCollection{
    

    private static void ListCars(){
      var cars = new List<Car>{
        new Car {Name = "Car2", Speed = 56, Color ="Red"},
        new Car {Name = "Car3", Speed = 56, Color ="Black"},
        new Car {Name = "Car4", Speed = 60, Color ="Grey"},
        new Car {Name = "Car1", Speed = 65, Color ="Red"}
      };
    
      cars.Sort();
      cars.ForEach(c => Console.Write(c));
    } 


    public static void Main(string [] args){
      ListCars();
    }
  }

  public class Car : IComparable<Car>{
    public string Name {get; set;}
    public int Speed {get; set;}
    public string Color {get; set;}
    
    public int CompareTo(Car other){
      // This method makes a single comparision that is used for sorting
      // Here, First we are sorting by the Color of the Car.
      // And if the Color of both the cars is same, then we are sorting on Speed
      // "in descinding order", that is why, we negate the result of compare
      int compare =  String.Compare(this.Color, other.Color, true);
      if(compare == 0){
        compare = this.Speed.CompareTo(other.Speed);
        compare = -1 * compare;
      }
      return compare;
    }

    public override string ToString(){
      return "["+Name+","+Speed+","+Color+"]\n";
    }
  }
}