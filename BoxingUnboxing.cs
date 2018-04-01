using System;
namespace dark{
  
  internal struct Point : IComparable{
    private readonly Int32 m_x, m_y;

    // Constructor to easily initialize the fields
    public Point(Int32 x, Int32 y){
      m_x = x;
      m_y = y;
    }

    // Override the ToString method inherited from System.ValueType
    public override String ToString(){

      //Return the Point as a string. Note : Calling the ToString method prevents boxing (read Pg#133)
      return String.Format("{0}, {1}", m_x.ToString(), m_y.ToString());
    }

    //Implementation of type-safe CompareTo method
    public Int32 CompareTo(Point other){
      //return the sign of the dist of this point from the other
      return Math.Sign(
        Math.Sqrt(m_x * m_x + m_y * m_y)
        -  Math.Sqrt(other.m_x * other.m_x + other.m_y * other.m_y)
        );
    }

    //Implementation ofIComparable's CompareTo method
    public Int32 CompareTo(Object other){
      if(GetType() != other.GetType())
        throw new ArgumentException("other is not a Point");

      //Calling the type safe CompareTo Method
      return CompareTo((Point) other);
    }
  }
  public static class Program{

    public static void Main(){

    //Read Pg #135 for depth explaination
    //Create 2 points instances on the Thread Stack, not Manged Heap
    Point p1 = new Point(10, 10);
    Point p2 = new Point(20, 20);


    // p1 doesnt need to be boxed to call ToString a virtual method (read Pg#133)
    Console.WriteLine(p1.ToString()); // "(10, 10)"

    
    // p1 does gets boxed to call GetType (a non virtual method)
    Console.WriteLine(p1.GetType());  // "Point"

    //p1 doesnot get boxed to call CompareTo
    //p2 doesnot get boxed bcoz CompareTo(Point) is getting called 
    Console.WriteLine(p1.CompareTo(p2));  // -1

    // p1 DOES gets boxed and reference is placed in c
    IComparable c = p1;
    Console.WriteLine(c.GetType());


    //p1 doesnot get boxed to call CompareTo
    //Bcoz CompareTo(Point) is not being passed a Point, CompareTo(Object) is being called,
    //which requires a reference to a boxed Point
    //c doesnt gets boxed, bcoz it is alreadya boxed point 
    Console.WriteLine(p1.CompareTo(c));  // 0

    //we are calling IComparable.CompareTo(Object)
    //c doesnot get boxed it already refers to a boxed Point
    //p2 does gets boxed bcoz CompareTo(Object) is being called
    Console.WriteLine(c.CompareTo(p2));  // -1

    // c is being unboxed and fields are copied into p2 
    p2 = (Point) c;

    // Proves that the fields got copied in to p2
    Console.WriteLine(p2.ToString()); // "(10, 10)"
    }
  } 
}