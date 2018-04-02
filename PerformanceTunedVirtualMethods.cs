using System;
namespace dark{

 public class MySet{
  private int m_length = 0;
  
  // Calling a vrtual method is slower than a nonvirtual method, if there are many methods in thr Type that are virtual.
  // It is common while defining a Type to offer several overloaded convenience methods, if we want all these methods to be polymorphic
  // the best thing to do is to make the most COMPLEX method virtual and leave all of the convinient methods nonvirtual
  // This convenience is not Virtual
  public int Find(Object value){
    return Find(value, 0, m_length);
  
  public virtual int Find(Object value, int startIndex, int endIndex){
    // Actual Implementation that can be overriden by the derived Type
    return 0;
  } 
 } 

// Other methods will go down here
}