using System;

namespace dark{
  //An Example of all the possible members in a Type
  
  public sealed class SomeType{

    //Nested Class
    private class SomeNestedType{

    }

    //Constant, read-only and static read/write fields
    private const Int32 c_Some_Constant = 1;
    private readonly String m_SomeReadOnlyField = "2";
    private static Int32 s_SomeReadWriteField = 3;

    //Type Constructor (for static members initialization)
    static SomeType{

    }

    //Instance Constructor
    public SomeType(Int32 x){

    }
    public SomeType(){}

    //Instance and static methods
    private String InstanceMethod(){
      return null;
    }

    public static void Main(){

    }

    //Instance Property
    public Int32  SomeProp{
      get {return 0;}
      set {}
    }

    //Instance parameterful property (indexer)
    public Int32 this[String s]{
      get {return 0;}
      set {}
    }

    //Instance Event
    public event EventHandler SomeEvent;
  }
}