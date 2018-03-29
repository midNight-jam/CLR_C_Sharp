using System;
using System.Collections.Generic;

namespace dark{
  public sealed class TryCollections{
    
    public static void tryList(){
      var salmons = new List<string>();
      salmons.Add("chinook");
      salmons.Add("coho");
      salmons.Add("pink");
      salmons.Add("sockeye");

      //Iterate through the list
      foreach (var salmon in salmons)
          Console.Write(salmon + " ");
      
      // using a collection initializer
      var fishes = new List<string>() {"shark", "whale", "dolphin", "Tuna"};
      foreach(var fish in fishes)
        Console.Write(fish + " ");

      //removing from a collection
      fishes.Remove("whale");

      foreach(var fish in fishes)
        Console.Write(fish + " ");

      //removing an element not in the collection
      fishes.Remove("whale"); // throws no exception

      foreach(var fish in fishes)
        Console.Write(fish + " ");

      Console.WriteLine("\n----------------------------------------\n");

      var numbers = new List<int> {0,1,2,3,4,5,6,7,8,9};
      foreach(var n in numbers)
        Console.Write(n + " ");

      Console.WriteLine("\n----------------------------------------\n");

      // Remove all the odd numbers 
      for(int i = 0; i < numbers.Count; i++){
        if((numbers[i] & 1) == 1)
          numbers.RemoveAt(i);
      }        

      foreach(var n in numbers)
        Console.Write(n + " ");

      Console.WriteLine("\n----------------------------------------\n");

      // Iterating with Lambda expresion
      // numbers.ForEach(n => Console.Write(n + " "));
      numbers.ForEach(n => printElement(n));

      var galaxies = new List<Galaxy> {
        new Galaxy {Name = "Tadpole", LightYears=400},
        new Galaxy {Name = "Pinwheel", LightYears=25},
        new Galaxy {Name = "Milkyway", LightYears=0},
        new Galaxy {Name = "Andromeda", LightYears=35}
      };

      galaxies.ForEach(g => printElement(g));
    }

    private static void printElement(Object o){
      Console.Write(o.ToString()+"|");
    }

    private class Galaxy{
      public string Name {get; set;} 
      public int LightYears {get; set;} 
      public override string ToString(){
        return Name+"_"+LightYears+"\n";
      }
    }

    public static void Main(string [] args){
        Console.WriteLine("C# Collections ");
        tryList();
    }
  }
}