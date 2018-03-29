using System;
using System.Collections.Generic;

namespace dark{
  public sealed class TryDictionary{


    private static void IterateThroughDictionary(){
        Dictionary<string, Element> elements =  buildDictionary();
        Console.WriteLine(elements.Count);
        foreach(KeyValuePair<string, Element> kvp in elements){
          Console.Write("key :" + kvp.Key);
          Console.Write(" value :" + kvp.Value);
        }
    }

    private static Dictionary<string, Element> buildDictionary(){
      var elements = new Dictionary<string, Element>();
      AddToDictionary(elements, "K", "Potassium", 19);
      AddToDictionary(elements, "Ca", "Calcium", 20);
      AddToDictionary(elements, "Sc", "Scandium", 21);
      AddToDictionary(elements, "Ti", "Titanium", 22);

      return elements;
    }


    private static Dictionary<string, Element> buildDictionary_2(){
      return new Dictionary<string, Element>{
        {"K", new Element(){Symbol = "K", Name = "Potassium", Number = 19}},
        {"Ca", new Element(){Symbol = "Ca", Name = "Calsium", Number = 20}},
        {"Sc", new Element(){Symbol = "Sc", Name = "Scandium", Number = 22}},
        {"Ti", new Element(){Symbol = "Ti", Name = "Titanium", Number = 21}}
      };
    }

    private static void FindInDictionary(string Symbol, Dictionary<string, Element> dictionary){
      if(!dictionary.ContainsKey(Symbol))
        Console.WriteLine(Symbol + "Not Found");
      else{
        Element theElement = dictionary[Symbol];
        Console.WriteLine("Found :: " + theElement);
      }
    }

    private static void FindInDictionary(string Symbol){
      Dictionary<string, Element> dictionary = buildDictionary_2();
      Element foundElement = null;
      if(!dictionary.TryGetValue(Symbol, out foundElement))
        Console.WriteLine(Symbol + "Not Found");
      else
        Console.WriteLine("Found :: " + foundElement);
    }

    private static void AddToDictionary(Dictionary<string, Element> elements, string sym, string name, int num){
      if(elements == null) return;
      
      Element newElement = new Element();
      newElement.Name = name;
      newElement.Symbol= sym;
      newElement.Number = num;

      elements.Add(key : newElement.Symbol, value : newElement);
    }

    public class Element {
      public string Name {get; set;}
      public string Symbol {get; set;}
      public int Number {get; set;}

       public override string ToString(){
        return Symbol+"_"+Name+"_"+Number+"\n";
      }
    }

    public static void Main(string [] args){
      Console.WriteLine("Trying Dictionary");
      IterateThroughDictionary();
      FindInDictionary("K", buildDictionary());
      FindInDictionary("Ca");
    }
  }
}