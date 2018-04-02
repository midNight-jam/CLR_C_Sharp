using System;
namespace dark{

 public class MySet{
  private int m_length = 0;
  
  // This convenience is not Virtual
  public int Find(Object value){
    return Find(value, 0, m_length);
  }

  public virtual int Find(Object value, int startIndex, int endIndex){
    // Actual Implementation that can be overriden by the derived Type
    return 0;
  } 
 } 

// Other methods will go down here
}